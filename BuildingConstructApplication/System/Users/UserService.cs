using Application.ClaimTokens;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Emgu.CV.Features2D;
using Emgu.CV.Ocl;
using FluentValidation.Results;
using Gridify;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Dynamic.Core;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.Users;

namespace Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly BuildingConstructDbContext _context;
        //private readonly string emailApi = "";
        public UserService(UserManager<User> userService, SignInManager<User> signInManager, RoleManager<Role> roleManager, IConfiguration config, BuildingConstructDbContext context)
        {
            _userService = userService;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }


        public async Task<BaseResponse<UserModels>> UpdateRole(UpdateRoleRequest request)
        {
            BaseResponse<UserModels> response = new();
            var users = await _userService.FindByNameAsync(request.Email);
            var roleNames = await _context.Roles.Where(x => x.Id.ToString().Equals(request.RoleId)).Select(x => x.Name).SingleOrDefaultAsync();

            if (request.RoleId == BaseCode.UsRole)
            {
                var builder = new Builder();
                builder.CreateBy = users.Id;
                await _context.Builders.AddAsync(builder);
                _context.SaveChanges();

                users.BuilderId = builder.Id;
                _context.Entry<User>(users).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else if (request.RoleId == BaseCode.StoreRole)
            {
                var store = new MaterialStore();
                store.CreateBy = users.Id;

                await _context.MaterialStores.AddAsync(store);
                _context.SaveChanges();

                users.MaterialStoreID = store.Id;
                _context.Entry(store).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else if (request.RoleId == BaseCode.ContractorRole)
            {
                var ctor = new Contractor();
                ctor.CreateBy = users.Id;

                await _context.Contractors.AddAsync(ctor);
                _context.SaveChanges();
                users.ContractorId = ctor.Id;
                _context.Entry(ctor).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            await _userService.AddToRoleAsync(users, roleNames);

            var roleName = (from usr in _context.Users
                            join userRole in _context.UserRoles on users.Id equals userRole.UserId
                            join role in _context.Roles on userRole.RoleId equals role.Id
                            select role.Name).FirstOrDefault();
            UserModels u = new()
            {
                Id = users.Id,
                Avatar = users.Avatar,
                FirstName = users.FirstName,
                LastName = users.LastName,
                Role = roleName,
                UserName = users.UserName
            };
            var userDTO = MapToDto(users, roleName);
            var token = await GenerateToken(userDTO);
            users.Token = token.Data.RefreshToken;
            users.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
            await _userService.UpdateAsync(users);
            response.Data = u;

            return response;
        }

        public async Task<BaseResponse<UserModels>> LoginGoogle(LoginGoogleRequest request)
        {
            BaseResponse<UserModels> response = new();

            var users = await _userService.FindByNameAsync(request.Email.ToUpper());// check email exist or not

            if (users == null)
            {
                var user = new User()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.Email,
                    Avatar = request.Avatar,
                    Provider = Provider.GOOGLE,
                    Status = Status.Level1,
                    Email = request.Email,
                };
                var rs = await _userService.CreateAsync(user, request.Email);

                UserModels us = new()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Avatar = user.Avatar,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };

                response.Data = us;
                response.Code = "201";
                response.Message = "Regist successfully but haven't got role";
                return response;
            }
            else
            {
                var roleName = (from usr in _context.Users
                                join userRole in _context.UserRoles on users.Id equals userRole.UserId
                                join role in _context.Roles on userRole.RoleId equals role.Id
                                select role.Name).FirstOrDefault();  //get roleName from db
                if (roleName == null)
                {
                    UserModels us = new()
                    {
                        UserName = users.UserName,
                        Avatar = users.Avatar,
                        FirstName = users.FirstName,
                        LastName = users.LastName,
                    };
                    response.Data = us;
                    response.Code = "202";
                    response.Message = "Role Name is null";
                    return response;
                }
                UserModels u = new()
                {
                    Id = users.Id,
                    UserName = users.UserName,
                    Avatar = users.Avatar,
                    FirstName = users.FirstName,
                    LastName = users.LastName,
                    Role = roleName
                };
                var userDTO = MapToDto(users, roleName);
                var token = await GenerateToken(userDTO);
                users.Token = token.Data.RefreshToken;
                users.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                await _userService.UpdateAsync(users);

                response.Data = userDTO;
                response.Data = u;
                response.Code = "200";
                response.Message = "Login Success";
            }
            return response;
        }




        public async Task<BaseResponse<UserDTO>> Login(LoginRequestDTO request)

        {
            BaseResponse<UserDTO> response = new();
            dynamic rs;
            //var user = await _userService.FindByNameAsync(request.UserName);
            rs = await _signInManager.PasswordSignInAsync(request.UserName, request.Password, request.RememberMe, true);// hàm login

            if (!rs.Succeeded)
            {
                var us = _context.Users.FirstOrDefault(x => x.PhoneNumber == request.PhoneNumber);

                if (us == null)
                {
                    return response;
                }
                else
                {
                    rs = await _signInManager.PasswordSignInAsync(us, request.Password, request.RememberMe, true);
                    if (rs.Succeeded)
                    {

                        var roleName = (from usr in _context.Users
                                        join userRole in _context.UserRoles on us.Id equals userRole.UserId
                                        join role in _context.Roles on userRole.RoleId equals role.Id
                                        select role.Name).FirstOrDefault();
                        if (roleName == null)
                        {
                            response.Code = "202";
                            response.Message = "Role Name is null";
                            return response;
                        }
                        var roles = await _userService.GetRolesAsync(us);
                        var userDTO = MapToDto(us, roleName);
                        var premium = await _context.Payments.Where(x => x.UserId.ToString().Equals(us.Id.ToString())).FirstOrDefaultAsync();
                        bool isPremium = false;
                        if (premium != null)
                        {
                            isPremium = true;
                        }
                        var token = await GenerateToken(userDTO);
                        us.Token = token.Data.RefreshToken;
                        us.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                        await _userService.UpdateAsync(us);
                        response.Data = new()
                        {
                            UserName = us.UserName,
                            Phone = us.PhoneNumber,
                            FirstName = us.FirstName,
                            LastName = us.LastName,
                            Status = us.Status,
                            Id = us.Id,
                            Address = us.Address,
                            Avatar = us.Avatar,
                            DOB = us.DOB,
                            Gender = us.Gender,
                            Role = roleName,
                            BuilderID = us.BuilderId,
                            ContractorID = us.ContractorId,
                            StoreID = us.MaterialStoreID,
                            Premium = isPremium
                        };

                    }
                }
                return response;


            }
            else
            {
                var user = await _userService.FindByNameAsync(request.UserName);
                if (user == null)
                {

                    return response;
                }
                var roleName = (from usr in _context.Users
                                join userRole in _context.UserRoles on user.Id equals userRole.UserId
                                join role in _context.Roles on userRole.RoleId equals role.Id
                                select role.Name).FirstOrDefault();
                if (roleName == null)
                {
                    response.Code = "202";
                    response.Message = "Role Name is null";
                    return response;
                }


                var roles = await _userService.GetRolesAsync(user);
                var userDTO = MapToDto(user, roleName);
                var token = await GenerateToken(userDTO);
                user.Token = token.Data.RefreshToken;
                user.RefreshTokenExpiryTime = (DateTime)token.Data.RefreshTokenExpiryTime;
                await _userService.UpdateAsync(user);
                response.Data = new()
                {
                    UserName = user.UserName,
                    Phone = user.PhoneNumber,
                    FirstName = user.LastName,
                    LastName = user.PhoneNumber,
                    Status = user.Status,
                    Id = user.Id,
                    Address = user.Address,
                    Avatar = user.Avatar,
                    DOB = user.DOB,
                    Gender = user.Gender,
                    Role = roleName
                };

            }


            return response;

        }
        private UserModels MapToDto(User user, string roleName)
        {
            var userDto = new UserModels()
            {
                Id = user.Id,
                UserName = user.UserName,
                Phone = user.PhoneNumber,
                BuilderID = user.BuilderId,
                StoreID = user.MaterialStoreID,
                ContractorID = user.ContractorId
            };
            return userDto;
        }

        public async Task<RegisterResponseDTO> Register(RegisterRequestDTO request)
        {
            RegisterResponseDTO response = new RegisterResponseDTO();
            RegisterRequestValidatorDTO validator = new();
            ValidationResult results = validator.Validate(request);

            var defaultRole = _roleManager.FindByIdAsync(request.RoleID).Result;

            if (!results.IsValid)
            {

                response.Data = null;
                response.Code = "202";
                foreach (var failure in results.Errors)
                {
                    response.Messages = failure.ErrorMessage.ToString();
                }
                return response;
            }
            else
            {
                var user = new User()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.Phone,
                    PhoneNumber = request.Phone,
                    Status = Status.Level1
                };

                var rs = await _userService.CreateAsync(user, request.Password);
                if (rs.Succeeded)
                {

                    await _userService.AddToRoleAsync(user, defaultRole.Name);

                    if (defaultRole.Id == Guid.Parse(BaseCode.UsRole))
                    {
                        var builder = new Builder
                        {
                            CreateBy = user.Id
                        };
                        await _context.Builders.AddAsync(builder);
                        _context.SaveChanges();

                        user.BuilderId = builder.Id;
                        _context.Entry<User>(user).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.StoreRole))
                    {
                        var store = new MaterialStore();
                        store.CreateBy = user.Id;

                        await _context.MaterialStores.AddAsync(store);
                        _context.SaveChanges();

                        user.MaterialStoreID = store.Id;
                        _context.Entry(store).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    else if (defaultRole.Id == Guid.Parse(BaseCode.ContractorRole))
                    {
                        var ctor = new Contractor();
                        ctor.CreateBy = user.Id;

                        await _context.Contractors.AddAsync(ctor);
                        _context.SaveChanges();
                        user.ContractorId = ctor.Id;
                        _context.Entry(ctor).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                    }
                    response.Data = user;
                    response.Code = "200";
                    response.Messages = "Regist successfully";
                    return response;
                }
                response.Code = "202";
                response.Messages = "Username already exists ";

                return response;
            }
        }

        public async Task<BaseResponse<Token>> GenerateToken(UserModels request)
        {
            var response = new BaseResponse<Token>();
            var token = new Token();
            var claims = new[]
            {
                new Claim("UserID",request.Id.ToString()),
                new Claim(ClaimTypes.Name,request.Phone!=null?request.Phone:request.UserName),
                new Claim(ClaimTypes.Role,string.Join(";",request.Role))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);
            var refreshtoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(30),
                signingCredentials: creds);
            var ReturnToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            var ReturnRFToken = new JwtSecurityTokenHandler().WriteToken(refreshtoken);
            //save rf token to db
            token.AccessToken = ReturnToken;
            token.RefreshToken = ReturnRFToken;
            token.RefreshTokenExpiryTime = refreshtoken.ValidTo;
            response.Data = token;
            response.Code = "200";
            response.Message = "generate token success";
            return response;
        }

        public async Task<BaseResponse<string>> RefreshToken(RefreshTokenResponse refreshToken)
        {
            BaseResponse<string> response = new();
            var tokenHandler = new JwtSecurityTokenHandler();

            dynamic principal = null;
            try
            {
                principal = GetPrincipalFromToken(refreshToken.RefreshToken);
                if (GetPrincipalFromToken(refreshToken.RefreshToken) == null)
                {
                    response.Code = "900";
                    response.Message = "Invalid Token";
                    return response;
                }
            }
            catch (SecurityTokenExpiredException)
            {

                response.Code = "901";
                response.Message = "Expired Token";
                return response;
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                response.Code = "900";
                response.Message = "Invalid Token";
                return response;
            }
            catch (ArgumentException)
            {
                response.Code = "900";
                response.Message = "Arugment invalid Token";
                return response;
            }


            string username = principal.Identity.Name;
            var user = await _userService.FindByNameAsync(username);

            var roles = await _userService.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim("UserID",user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
                };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var accesstoken = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);
            TokenResponse token = new();
            var newAccessToken = new JwtSecurityTokenHandler().WriteToken(accesstoken);
            token.AccessToken = newAccessToken;
            response.Data = token.AccessToken;
            response.Code = "200";
            response.Message = "Generate new token successfully";
            return response;
        }
        private ClaimsPrincipal GetPrincipalFromToken(string? token)

        {
            var principal = (dynamic)null;
            try
            {
                string issuer = _config.GetValue<string>("Tokens:Issuer");
                string signingKey = _config.GetValue<string>("Tokens:Key");
                byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes),
                };
                principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
            }
            catch (SecurityTokenExpiredException)
            {
                throw new SecurityTokenExpiredException();
            }
            catch (SecurityTokenInvalidSignatureException)
            {
                throw new SecurityTokenInvalidSignatureException();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            return principal;
        }





        private UserDetailDTO MapToDetailDTO(User user, int status)
        {
            //1 Builder
            //2 Ctor
            //3 Material Store

            UserDetailDTO userDetail;

            if (status == 1)
            {

                var tmp = _context.BuilderSkills.Include(x => x.Skill).Where(x => x.BuilderSkillID == user.BuilderId).ToList();

                var contrusctionType = _context.WorkerContructionTypes

                    .Include(x => x.ConstructionType)
                    .Where(x => x.BuilderId == user.BuilderId).ToList();


                List<WorkerListType> ls = new();
                foreach (var item in contrusctionType)
                {

                    WorkerListType workerListType = new()
                    {
                        ConstructionTypeId = item.ConstructionTypeId,
                        Name = item.ConstructionType.Name
                    };
                    ls.Add(workerListType);
                }
                var appliedCount = _context.AppliedPosts.Where(x => x.BuilderID == user.Builder.Id).Count();
                var inviteCount = _context.PostInvites.Where(x => x.BuilderId == user.Builder.Id).Count();
                List<string> images = new();

                if (user.Builder.Image != null)
                {
                    var splitImage = user.Builder.Image.Split(",").ToList();

                    images.AddRange(splitImage);
                }


                DetailBuilder detailBuilder = new()
                {
                    BuilderSkills = MapToSkillDTO(tmp),
                    Id = user.Builder.Id,
                    Place = user.Builder.Place,
                    TypeName = user.Builder.Type?.Name == null ? null : user.Builder.Type?.Name,
                    TypeID = user.Builder.TypeID,
                    ExperienceDetail = user.Builder.ExperienceDetail,
                    Certificate = user.Builder.Certificate,
                    Experience = user.Builder.Experience,
                    Image = user.Builder.Image,
                    ConstructionType = ls,
                    AppliedCount = appliedCount,
                    InviteCount = inviteCount,
                    Images = images.Any() ? images : null

                };


                userDetail = new()
                {
                    Address = user.Address,
                    Avatar = user.Avatar,
                    DOB = user.DOB,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Gender = user.Gender,
                    IdNumber = user.IdNumber,
                    LastName = user.LastName,
                    Status = user.Status,
                    Phone = user.PhoneNumber,
                    Builder = detailBuilder,
                    LastModifiedAt = user.LastModifiedAt
                };

            }
            else if (status == 2)
            {
                DetailContractor detailContractor = new()
                {
                    CompanyName = user.Contractor.CompanyName,
                    Description = user.Contractor.Description,
                    Id = user.Contractor.Id,
                    Website = user.Contractor.Website
                };


                userDetail = new()
                {
                    Address = user.Address,
                    Avatar = user.Avatar,
                    DOB = user.DOB,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Gender = user.Gender,
                    IdNumber = user.IdNumber,
                    LastName = user.LastName,
                    Status = user.Status,
                    Phone = user.PhoneNumber,
                    Contractor = detailContractor,
                    LastModifiedAt = user.LastModifiedAt
                };
            }
            else
            {
                DetailMaterialStore detailMaterial = new()
                {
                    Description = user.MaterialStore.Description,
                    Id = user.MaterialStore.Id,
                    Website = user.MaterialStore.Website,
                    Experience = user.MaterialStore.Experience,
                    Image = user.MaterialStore.Image,
                    Place = user.MaterialStore.Place,
                    TaxCode = user.MaterialStore.TaxCode
                };


                userDetail = new()
                {
                    Address = user.Address,
                    Avatar = user.Avatar,
                    DOB = user.DOB,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Gender = user.Gender,
                    IdNumber = user.IdNumber,
                    LastName = user.LastName,
                    Status = user.Status,
                    Phone = user.PhoneNumber,
                    DetailMaterialStore = detailMaterial,
                    LastModifiedAt = user.LastModifiedAt
                };
            }


            return userDetail;
        }

        private List<BuilderSkillsDTO> MapToSkillDTO(List<BuilderSkill> skills)
        {
            List<BuilderSkillsDTO> ls = new();

            foreach (var x in skills)
            {
                BuilderSkillsDTO dto = new()
                {
                    Id = x.SkillID,
                    Name = x.Skill.Name
                };
                ls.Add(dto);
            }
            return ls;
        }

        public async Task<BaseResponse<UserDetailDTO>> GetProfile(Guid userID)
        {
            BaseResponse<UserDetailDTO> response;
            var user = await _context.Users.Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();

            if (user == null)
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.NOTFOUND_MESSAGE
                };
                return response;
            }

            var rolename = _userService.GetRolesAsync(user).Result;


            if (rolename.First().Equals("User"))
            {
                var result = await _context.Users
                                    .Include(x => x.Builder)
                                        .ThenInclude(x => x.Type)
                                    .Where(x => x.Id.Equals(userID))
                                    .FirstOrDefaultAsync();

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Data = MapToDetailDTO(result, 1),
                    Message = BaseCode.SUCCESS_MESSAGE
                };
                return response;

            }
            else if (rolename.First().Equals("Contractor"))
            {
                var result = await _context.Users.Include(x => x.Contractor).Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Data = MapToDetailDTO(result, 2),
                    Message = BaseCode.SUCCESS_MESSAGE
                };
                return response;
            }
            else
            {
                var result = await _context.Users.Include(x => x.MaterialStore).Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Data = MapToDetailDTO(result, 3),
                    Message = BaseCode.SUCCESS_MESSAGE
                };
                return response;

            }

        }
        public async Task<BaseResponse<string>> UpdateBuilderProfile(UpdateBuilderRequest request, Guid userID)
        {
            BaseResponse<string> response;

            var user = await _context.Users.Include(x => x.Builder).FirstOrDefaultAsync(x => x.Id.Equals(userID));

            if (user != null)
            {
                if (!string.IsNullOrEmpty(request.FirstName))
                {
                    user.FirstName = request.FirstName;
                }
                if (!string.IsNullOrEmpty(request.Image))
                {
                    user.Builder.Image = request.Image;
                }

                if (!string.IsNullOrEmpty(request.LastName))
                {
                    user.LastName = request.LastName;

                }
                if (!string.IsNullOrEmpty(request.Email))
                {
                    user.Email = request.Email;

                }
                if (!string.IsNullOrEmpty(request.Address))
                {
                    user.Address = request.Address;

                }
                if (!string.IsNullOrEmpty(request.Gender.ToString()))
                {
                    user.Gender = request.Gender;

                }
                if (!string.IsNullOrEmpty(request.IdNumber))
                {
                    user.IdNumber = request.IdNumber;

                }

                if (!string.IsNullOrEmpty(request.DOB.ToString()))
                {
                    user.DOB = request.DOB;

                }
                if (!string.IsNullOrEmpty(request.Avatar))
                {
                    user.Avatar = request.Avatar;

                }
                if (!string.IsNullOrEmpty(request.Phone))
                {
                    user.PhoneNumber = request.Phone;

                }


                //

                if (request.ExperienceDetail != null)
                {
                    if (request.ExperienceDetail.Length == 0)
                    {
                        user.Builder.ExperienceDetail = null;
                    }
                    else
                    {

                        user.Builder.ExperienceDetail = request.ExperienceDetail;
                    }

                }




                if (!string.IsNullOrEmpty(request.Experience.ToString()))
                {
                    user.Builder.Experience = request.Experience;

                }
                if (request.Certificate != null)
                {
                    if (request.Certificate.Length == 0)
                    {
                        user.Builder.Certificate = null;
                    }
                    else
                    {
                        user.Builder.Certificate = request.Certificate;

                    }
                }

                if (!string.IsNullOrEmpty(request.TypeID.ToString()))
                {
                    user.Builder.TypeID = request.TypeID;

                }
                if (!string.IsNullOrEmpty(request.Place.ToString()))
                {
                    user.Builder.Place = request.Place;

                }

                if (request.Skills != null)
                {
                    var skills = await _context.BuilderSkills.Where(x => x.BuilderSkillID.Equals(user.BuilderId)).ToListAsync();
                    if (skills.Any())
                    {
                        _context.RemoveRange(skills);
                        await _context.SaveChangesAsync();
                    }


                    foreach (var x in request.Skills)
                    {
                        BuilderSkill newSkills = new()
                        {
                            BuilderSkillID = user.BuilderId.Value,
                            SkillID = x
                        };
                        await _context.BuilderSkills.AddAsync(newSkills);
                        await _context.SaveChangesAsync();
                    }
                }
                if (request.WorkerConstructionType != null)
                {
                    var type = await _context.WorkerContructionTypes.Where(x => x.BuilderId.Equals(user.BuilderId)).ToListAsync();
                    if (type.Any())
                    {
                        _context.RemoveRange(type);
                        await _context.SaveChangesAsync();
                    }


                    foreach (var x in request.WorkerConstructionType)
                    {
                        WorkerContructionType newSkills = new()
                        {
                            BuilderId = user.BuilderId.Value,
                            ConstructionTypeId = x
                        };
                        await _context.WorkerContructionTypes.AddAsync(newSkills);
                        await _context.SaveChangesAsync();
                    }
                }
                _context.Users.Update(user);
                await _context.SaveChangesAsync();


                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE
                };


            }
            else
            {
                response = new()
                {
                    Message = BaseCode.NOTFOUND_MESSAGE,
                    Code = BaseCode.ERROR
                };
            }
            return response;
        }

        public async Task<BaseResponse<string>> UpdateContractorProfile(UpdateContractorRequest request, Guid userID)
        {
            BaseResponse<string> response;

            var user = await _context.Users.Include(x => x.Contractor).FirstOrDefaultAsync(x => x.Id.Equals(userID));

            if (user != null)
            {

                if (!string.IsNullOrEmpty(request.FirstName))
                {
                    user.FirstName = request.FirstName;
                }

                if (!string.IsNullOrEmpty(request.LastName))
                {
                    user.LastName = request.LastName;

                }
                if (!string.IsNullOrEmpty(request.Email))
                {
                    user.Email = request.Email;

                }
                if (!string.IsNullOrEmpty(request.Address))
                {
                    user.Address = request.Address;

                }
                if (!string.IsNullOrEmpty(request.Gender.ToString()))
                {
                    user.Gender = request.Gender;

                }
                if (!string.IsNullOrEmpty(request.IdNumber))
                {
                    user.IdNumber = request.IdNumber;

                }
                if (!string.IsNullOrEmpty(request.DOB.ToString()))
                {
                    user.DOB = request.DOB;

                }
                if (!string.IsNullOrEmpty(request.Avatar))
                {
                    user.Avatar = request.Avatar;

                }
                if (!string.IsNullOrEmpty(request.Phone))
                {
                    user.PhoneNumber = request.Phone;

                }

                if (!string.IsNullOrEmpty(request.CompanyName))
                {
                    user.Contractor.CompanyName = request.CompanyName;


                }
                if (!string.IsNullOrEmpty(request.Description))
                {
                    user.Contractor.Description = request.Description;

                }
                if (!string.IsNullOrEmpty(request.Website))
                {
                    user.Contractor.Website = request.Website;
                }
                _context.Users.Update(user);
                await _context.SaveChangesAsync();


                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE
                };


            }
            else
            {
                response = new()
                {
                    Message = BaseCode.NOTFOUND_MESSAGE,
                    Code = BaseCode.ERROR
                };
            }
            return response;
        }

        public async Task<BaseResponse<string>> UpdateStoreProfile(UpdateStoreRequest request, Guid userID)
        {
            BaseResponse<string> response;

            var user = await _context.Users.Include(x => x.MaterialStore).FirstOrDefaultAsync(x => x.Id.Equals(userID));

            if (user != null)
            {
                if (!string.IsNullOrEmpty(request.FirstName))
                {
                    user.FirstName = request.FirstName;
                }

                if (!string.IsNullOrEmpty(request.LastName))
                {
                    user.LastName = request.LastName;

                }
                if (!string.IsNullOrEmpty(request.Address))
                {
                    user.Address = request.Address;

                }
                if (!string.IsNullOrEmpty(request.Email))
                {
                    user.Email = request.Email;

                }
                if (!string.IsNullOrEmpty(request.Gender.ToString()))
                {
                    user.Gender = request.Gender;

                }
                if (!string.IsNullOrEmpty(request.IdNumber))
                {
                    user.IdNumber = request.IdNumber;

                }
                if (!string.IsNullOrEmpty(request.DOB.ToString()))
                {
                    user.DOB = request.DOB;

                }
                if (!string.IsNullOrEmpty(request.Avatar))
                {
                    user.Avatar = request.Avatar;

                }
                if (!string.IsNullOrEmpty(request.Phone))
                {
                    user.PhoneNumber = request.Phone;

                }
                if (!string.IsNullOrEmpty(request.TaxCode))
                {
                    user.MaterialStore.TaxCode = request.TaxCode;

                }
                if (!string.IsNullOrEmpty(request.Description))
                {
                    user.MaterialStore.Description = request.Description;


                }
                if (!string.IsNullOrEmpty(request.Website))
                {
                    user.MaterialStore.Website = request.Website;


                }
                if (!string.IsNullOrEmpty(request.Experience))
                {
                    user.MaterialStore.Experience = request.Experience;


                }
                if (!string.IsNullOrEmpty(request.Image))
                {
                    user.MaterialStore.Image = request.Image;


                }
                if (!string.IsNullOrEmpty(request.Place.ToString()))
                {
                    user.MaterialStore.Place = request.Place;


                }







                _context.Users.Update(user);
                await _context.SaveChangesAsync();


                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE
                };


            }
            else
            {
                response = new()
                {
                    Message = BaseCode.NOTFOUND_MESSAGE,
                    Code = BaseCode.ERROR
                };
            }
            return response;
        }

        public async Task<BasePagination<List<UserDetailDTO>>> GetContractorFavorite(PaginationFilter filter)
        {
            BasePagination<List<UserDetailDTO>> response;
            List<UserDetailDTO> ls = new();
            List<int> contractorIDFromDB = new();
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "LastModifiedAt";
            }



            IQueryable<AppliedPost> query2 = _context.AppliedPosts;

            //var newList = _context.AppliedPosts.GroupBy(x => x.PostID)
            //      .OrderByDescending(g => g.Count())
            //      .SelectMany(g => g)
            //      .ToList();


            var query = from history in _context.AppliedPosts
                        group history by history.PostID into historyGroup
                        orderby historyGroup.Key
                        select new { post = historyGroup.Key, postCount = historyGroup.Count() };


            var data = query.Skip((filter.PageNumber - 1) * filter.PageSize)
                     .Take(filter.PageSize).ToList();




            if (!data.Any())
            {
                contractorIDFromDB = await _context.Users.Include(x => x.Contractor).Where(x => x.ContractorId != null).Select(x => (int)x.ContractorId).ToListAsync();

            }


            if (filter.FilterRequest != null)
            {
                totalRecord = data.Count;
            }
            else
            {
                totalRecord = await _context.AppliedPosts.CountAsync();
            }

            if (!data.Any() && !contractorIDFromDB.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
                    Pagination = null
                };
            }
            else
            {
                double totalPages;

                totalPages = ((double)totalRecord / (double)filter.PageSize);

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecord
                };


                if (data.Any())
                {

                    foreach (var item in data)
                    {
                        ls.Add(MapToDetailDTO(item.post));
                    }
                }
                else
                {
                    foreach (var item in contractorIDFromDB)
                    {
                        ls.Add(MapToDetailDTO(item));
                    }
                }



                var final = ls.DistinctBy(x => x.UserId).ToList();



                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = final,
                    Pagination = pagination
                };
            }
            return response;
        }

        private UserDetailDTO MapToDetailDTO(int postID)
        {
            UserDetailDTO userDetail;

            var post = _context.ContractorPosts
                .Include(x => x.Contractor)
                        .ThenInclude(x => x.User)
                .Where(x => x.Id == postID).FirstOrDefault();


            DetailContractor detailContractor = new()
            {
                CompanyName = post.Contractor.CompanyName,
                Description = post.Contractor.Description,
                Id = post.Contractor.Id,
                Website = post.Contractor.Website
            };


            userDetail = new()
            {
                Address = post.Contractor.User.Address,
                Avatar = post.Contractor.User.Avatar,
                DOB = post.Contractor.User.DOB,
                Email = post.Contractor.User.Email,
                FirstName = post.Contractor.User.FirstName,
                Gender = post.Contractor.User.Gender,
                IdNumber = post.Contractor.User.IdNumber,
                LastName = post.Contractor.User.LastName,
                Status = post.Contractor.User.Status,
                Phone = post.Contractor.User.PhoneNumber,
                Contractor = detailContractor,
                LastModifiedAt = post.Contractor.User.LastModifiedAt,
                UserId = post.Contractor.CreateBy
            };
            return userDetail;
        }

        public async Task<BasePagination<List<UserDetailDTO>>> GetBuilderFavorite(PaginationFilter filter)
        {
            BasePagination<List<UserDetailDTO>> response;
            List<UserDetailDTO> ls = new();
            List<int> builderIDFromDB = new();
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }



            IQueryable<AppliedPost> query2 = _context.AppliedPosts;


            var query = from commitment in _context.PostCommitments
                        group commitment by commitment.BuilderID into builderGroup
                        orderby builderGroup.Key
                        select new { builderID = builderGroup.Key, count = builderGroup.Count() };


            var data = query.Skip((filter.PageNumber - 1) * filter.PageSize)
                     .Take(filter.PageSize).ToList();

            if (!data.Any())
            {
                builderIDFromDB = await _context.Users.Include(x => x.Builder).Where(x => x.BuilderId != null).Select(x => (int)x.BuilderId).ToListAsync();

            }

            if (filter.FilterRequest != null)
            {
                totalRecord = data.Count;
            }
            else
            {
                totalRecord = await _context.PostCommitments.CountAsync();
            }


            if (!data.Any() && !builderIDFromDB.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
                    Pagination = null
                };
            }
            else
            {
                double totalPages;

                totalPages = ((double)totalRecord / (double)filter.PageSize);

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecord
                };

                if (data.Any())
                {

                    foreach (var item in data)
                    {
                        ls.Add(MapBuilderFavorite(item.builderID.Value));
                    }
                }
                else
                {
                    foreach (var item in builderIDFromDB)
                    {
                        ls.Add(MapBuilderFavorite(item));
                    }
                }

                var final = ls.DistinctBy(x => x.UserId).ToList();


                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = final,
                    Pagination = pagination
                };
            }
            return response;
        }

        private UserDetailDTO MapBuilderFavorite(int builderID)
        {
            UserDetailDTO userDetail;

            var user = _context.Builders
                 .Include(x => x.User)
                 .Include(x => x.Type)
                 .Where(x => x.Id == builderID).FirstOrDefault();


            var tmp = _context.BuilderSkills.Include(x => x.Skill).Where(x => x.BuilderSkillID == builderID).ToList();

            var contrusctionType = _context.WorkerContructionTypes
                .Include(x => x.ConstructionType)
                .Where(x => x.BuilderId == builderID).ToList();


            List<WorkerListType> ls = new();
            foreach (var item in contrusctionType)
            {

                WorkerListType workerListType = new()
                {
                    ConstructionTypeId = item.ConstructionTypeId,
                    Name = item.ConstructionType.Name
                };
                ls.Add(workerListType);
            }


            DetailBuilder detailBuilder = new()
            {
                BuilderSkills = MapToSkillDTO(tmp),
                Id = user.Id,
                Place = user.Place,
                TypeName = user.Type?.Name == null ? null : user.Type?.Name,
                TypeID = user.TypeID,
                ExperienceDetail = user.ExperienceDetail,
                Certificate = user.Certificate,
                Experience = user.Experience,
                ConstructionType = ls
            };


            userDetail = new()
            {
                Address = user.User?.Address,
                Avatar = user.User.Avatar,
                DOB = user.User.DOB,
                Email = user.User.Email,
                FirstName = user.User.FirstName,
                Gender = user.User.Gender,
                IdNumber = user.User.IdNumber,
                LastName = user.User.LastName,
                Status = user.User.Status,
                Phone = user.User.PhoneNumber,
                Builder = detailBuilder,
                LastModifiedAt = user.LastModifiedAt,
                UserId = user.User.Id
            };

            return userDetail;

        }




        public async Task<BasePagination<List<UserDetailDTO>>> GetStoreFavorite(PaginationFilter filter)
        {
            BasePagination<List<UserDetailDTO>> response;
            List<UserDetailDTO> ls = new();
            List<int> storeIDFromDB = new();
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }

            var query = from bill in _context.Bills
                        group bill by bill.StoreID into storeGroup
                        orderby storeGroup.Key
                        select new { storeID = storeGroup.Key, count = storeGroup.Count() };


            var data = query.Skip((filter.PageNumber - 1) * filter.PageSize)
                     .Take(filter.PageSize).ToList();

            if (!data.Any())
            {
                storeIDFromDB = await _context.Users.Include(x => x.MaterialStore).Where(x => x.MaterialStoreID != null).Select(x => (int)x.MaterialStoreID).ToListAsync();

            }


            if (filter.FilterRequest != null)
            {
                totalRecord = data.Count;
            }
            else
            {
                totalRecord = await _context.Bills.CountAsync();
            }

            if (!data.Any() && !storeIDFromDB.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
                    Pagination = null
                };
            }
            else
            {
                double totalPages;

                totalPages = ((double)totalRecord / (double)filter.PageSize);

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecord
                };

                if (data.Any())
                {
                    foreach (var item in data)
                    {
                        ls.Add(MapStoreFavorite(item.storeID.Value));
                    }
                }
                else
                {
                    foreach (var item in storeIDFromDB)
                    {
                        ls.Add(MapStoreFavorite(item));
                    }
                }
                var final = ls.DistinctBy(x => x.UserId).ToList();






                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = final,
                    Pagination = pagination
                };
            }
            return response;
        }


        private UserDetailDTO MapStoreFavorite(int storeID)
        {
            UserDetailDTO userDetail;

            var store = _context.MaterialStores
                 .Include(x => x.User)
                 .Where(x => x.Id == storeID).FirstOrDefault();


            DetailMaterialStore detailMaterial = new()
            {
                Description = store.Description,
                Id = store.Id,
                Website = store.Website,
                Experience = store.Experience,
                Image = store.Image,
                Place = store.Place,
                TaxCode = store.TaxCode
            };


            userDetail = new()
            {
                Address = store.User.Address,
                Avatar = store.User.Avatar,
                DOB = store.User.DOB,
                Email = store.User.Email,
                FirstName = store.User.FirstName,
                Gender = store.User.Gender,
                IdNumber = store.User.IdNumber,
                LastName = store.User.LastName,
                Status = store.User.Status,
                Phone = store.User.PhoneNumber,
                DetailMaterialStore = detailMaterial,
                LastModifiedAt = store.LastModifiedAt,
                UserId = store.User.Id
            };
            return userDetail;

        }

        public async Task<BaseResponse<UserDetailDTO>> GetProfile(RefreshToken refreshToken)
        {
            BaseResponse<UserDetailDTO> response = new();
            var tokenHandler = new JwtSecurityTokenHandler();


            var principal = GetPrincipalFromToken(refreshToken.refreshToken);

            if (principal == null)
            {
                response.Code = "501";
                response.Message = "Invalid Token";
                return response;
            }
            if (principal.Identity == null)
            {
                response.Code = "201";
                response.Message = "Please update all information in your profile";
                return response;
            }
            var us =await _context.Users.Where(x => x.Token.Equals(refreshToken.refreshToken)).FirstOrDefaultAsync();
            if (us == null || us.Token != refreshToken.refreshToken || us.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                response.Code = "500";
                response.Message = "Expired Refresh Token in getProfile";
                return response;
            }
            var role = await _userService.GetRolesAsync(us);

            UserDetailDTO profile = new UserDetailDTO()
            {
                UserId = us.Id,
                Email = us.Email,
                FirstName = us.FirstName,
                LastName = us.LastName,
                Phone = us.PhoneNumber,
                DOB = us.DOB,
                Gender = us.Gender,
                Avatar = us.Avatar,
                Address = us.Address,
                IdNumber=us.IdNumber,
                Status=us.Status,
                Role = role[0]
            };
            response.Data = profile;
            response.Code = "200";
            response.Message = "msg";
            return response;
        }
    }
}
