using Application.System.ContractorPosts;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BuilderPosts;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.SavePost;
using ViewModels.Users;

namespace Application.System.SavePost
{
    public class SaveService : ISaveService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;

        public SaveService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<BaseResponse<List<SavePostDetailDTO>>> GetSavePostByUsID()
        {
            BaseResponse<List<SavePostDetailDTO>> response = new();
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            if (identifierClaim == null)
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = "202";
                return response;
            }
            var userID = identifierClaim.Value.ToString();
            var result = await _context.Saves.Include(x => x.ContractorPost).Include(x => x.BuilderPost).Where(x => x.UserId.ToString().Equals(userID)).ToListAsync();
            List<SavePostDetailDTO> list = new();
            if (result != null)
            {
                foreach (var item in result)
                {
                    list.Add(await MapToDTO(item));
                }
                response.Data = list;
                response.Message = BaseCode.SUCCESS;
                response.Code = BaseCode.SUCCESS_MESSAGE;
            }
            else
            {
                response.Message =BaseCode.ERROR_MESSAGE;
                response.Code = BaseCode.ERROR;
            }
            return response;
        }
        private async Task<SavePostDetailDTO> MapToDTO(Save save)
        {
            SavePostDetailDTO dto = new();
            if (dto.BuilderPost == null)
            {
                dto.UserId = save.UserId;
                dto.ContractorPost = await GetContractorPost(save.ContractorPost);
                dto.CreatedDate = save.Date;
            }else if (dto.ContractorPost == null)
            {
                dto.UserId = save.UserId;
                dto.BuilderPost = await GetBuilderPost(save.BuilderPost);
                dto.CreatedDate = save.Date;
            }
            else
            {
                dto.UserId = save.UserId;
                dto.ContractorPost = await GetContractorPost(save.ContractorPost);
                dto.BuilderPost = await GetBuilderPost(save.BuilderPost);
                dto.CreatedDate = save.Date;
            }
            return dto;
        }
        private async Task<List<ContractorPostDetailDTO>> GetContractorPost(ContractorPost post)
        {
            var results = await _context.ContractorPosts.Where(x => x.Id == post.Id).ToListAsync();

            var final = new List<ContractorPostDetailDTO>();
            ContractorPostDetailDTO dto = new();

            foreach (var x in results)
            {
                dto.Id = x.Id;
                dto.Title = x.Title;
                dto.ProjectName = x.ProjectName;
                dto.Description = x.Description;
                dto.Required = x.Required;
                dto.NumberPeople = x.NumberPeople;
                dto.Benefit = x.Benefit;
                dto.Required = x.Required;
                dto.type = await GetTypeAndSkillFromPost(post.Id);
                dto.Salaries = x.Salaries;
                dto.LastModifiedAt = x.LastModifiedAt;
                dto.PeopleRemained = x.PeopeRemained;
                dto.PostCategories = x.PostCategories;
                dto.Place = x.Place;
                dto.StarDate = x.StarDate;
                dto.EndDate = x.EndDate;
                dto.ProductSystem = await GetProductFromPost(post.Id);
                dto.Author = await GetUserProfile(post.CreateBy);
                final.Add(dto);
            }
            return final;
        }
        private async Task<List<TypeModels>> GetTypeAndSkillFromPost(int postID)
        {
            var results = await _context.ContractorPostTypes.Include(x => x.Type).Where(x => x.ContractorPostID == postID).ToListAsync();
            var rsSkill = await _context.ContractorPostSkills.Include(x => x.Skills).Where(x => x.ContractorPostID == postID).ToListAsync();
            var final = new List<TypeModels>();
            foreach (var item in results)
            {
                var type = new TypeModels();
                type.id = item.TypeID;
                type.name = item.Type.Name;
                type.SkillArr = new();
                foreach (var i in rsSkill)
                {
                    if (i.Skills.TypeId.Equals(item.TypeID))
                    {
                        var skillArr = new SkillArr();
                        skillArr.id = i.SkillID;
                        skillArr.name = i.Skills.Name;
                        skillArr.fromSystem = i.Skills.FromSystem;
                        skillArr.TypeId = i.Skills.TypeId;
                        type.SkillArr.Add(skillArr);
                    }
                }
                final.Add(type);
            }
            if (rsSkill.Where(x => x.Skills.TypeId == null).ToList().Any())
            {
                var t = new TypeModels();
                foreach (var i in rsSkill.Where(x => x.Skills.TypeId == null).ToList())
                {
                    t.SkillArr = new();
                    var skillArr = new SkillArr();
                    skillArr.id = i.SkillID;
                    skillArr.name = i.Skills.Name;
                    skillArr.fromSystem = i.Skills.FromSystem;
                    skillArr.TypeId = i.Skills.TypeId;
                    t.SkillArr.Add(skillArr);
                    final.Add(t);
                }
            }
            return final;
        }
        private async Task<List<BuilderPostDetailDTO>> GetBuilderPost(BuilderPost post)
        {
            var results = _context.BuilderPosts.Where(x => x.Id == post.Id).ToList();

            var final = new List<BuilderPostDetailDTO>();
            BuilderPostDetailDTO dto = new();

            foreach (var x in results)
            {
                dto.Id = x.Id;
                dto.Title = x.Title;
                dto.Description = x.Description;
                dto.PostCategories = x.PostCategories;
                dto.Status = x.Status;
                dto.type = await GetTypeAndSkillFromPost(post.Id);
                dto.LastModifiedAt = x.LastModifiedAt;
                dto.Salaries = x.Salaries;
                dto.Place = x.Place;
                dto.Author = await GetUserProfile(post.CreateBy);
                final.Add(dto);
            }
            return final;
        }
        private async Task<List<ContractorPostProductDTO>> GetProductFromPost(int postID)
        {
            var query = from cP in _context.ContractorPostProducts
                        join pSys in _context.ProductSystems on cP.ProductSystemID equals pSys.Id into rs1
                        from r in rs1.DefaultIfEmpty()
                        join d in _context.ContractorPostProducts on r.Id equals d.ProductSystemID into rs4
                        from r4 in rs4.DefaultIfEmpty()
                        join cat in _context.ProductSystemCategories on r.Id equals cat.ProductSystemID into rs2
                        from r1 in rs2.DefaultIfEmpty()
                        join c in _context.Categories on r1.SystemCategoriesID equals c.ID into rs3
                        from r3 in rs3.DefaultIfEmpty()
                        where r4.ContractorPostID == postID && cP.ContractorPostID==postID
                        select new
                        {
                            ProductSystemCategories = r1,
                            ProductSystem = r,
                            Categories = r3,
                            ContractorPostProduct = r4
                        };
            var result = await query.AsNoTracking().ToListAsync();
            var final = new List<ContractorPostProductDTO>();
            foreach (var x in result)
            {
                ContractorPostProductDTO dto = new();
                dto.Id = x.ProductSystem.Id;
                dto.Name = x.ProductSystem.Name;
                dto.Quantity = x.ContractorPostProduct.Quantity;
                dto.Brand = x.ProductSystem.Brand;
                dto.Description = x.ProductSystem.Description;
                dto.Categories = x.Categories;
                final.Add(dto);
            }
            return final;
        }
        public async Task<UserModelsDTO> GetUserProfile(Guid userID)
        {
            var results = await _context.Users.Where(x => x.Id.ToString().Equals(userID.ToString())).SingleOrDefaultAsync();
            var roleid = await _context.UserRoles.Where(x => x.UserId.Equals(userID)).Select(x => x.RoleId).SingleOrDefaultAsync();
            var final = new UserModelsDTO();
            final.UserName = results.UserName;
            final.Phone = results.PhoneNumber;
            final.FirstName = results.FirstName;
            final.LastName = results.LastName;
            final.Address = results.Address;
            final.Gender = results.Gender;
            final.Avatar = results.Avatar;
            final.DOB = results.DOB;
            final.Email = results.Email;
            final.RoleName = await _context.Roles.Where(x => x.Id.Equals(roleid)).Select(x => x.Name).SingleOrDefaultAsync();
            return final;
        }

        public async Task<BaseResponse<string>> SavePost(SavePostRequest request)
        {
            BasePagination<string> response = new();
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            if (identifierClaim == null)
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = "202";
                return response;
            }
            var userID = identifierClaim.Value;
            Save save = new()
            {
                Date = DateTime.Now,
                BuilderPostId = request.BuiderPostId,
                ContractorPostId = request.ContractorPostId,
                UserId = Guid.Parse(userID)
            };
            await _context.Saves.AddAsync(save);
            var rs = await _context.SaveChangesAsync();
            if (rs > 0)
            {
                response.Message = BaseCode.SUCCESS_MESSAGE;
                response.Code = "200";
            }
            else
            {
                response.Message = BaseCode.ERROR_MESSAGE;
                response.Code = "202";
            }
            return response;
        }

        public async Task<bool> DeleteSave(DeleteSaveRequest request)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            dynamic save;
            if (request.BuilderPostId == null)
            {
                save = await _context.Saves.FirstOrDefaultAsync(x => x.ContractorPostId == request.ContractorPostId && x.UserId.ToString().Equals(userID.ToString()));

            }
            else
            {
                save = await _context.Saves.FirstOrDefaultAsync(x => x.BuilderPostId == request.BuilderPostId && x.UserId.Equals(userID));
            }

            if (save == null)
            {
                return false;
            }
            _context.Saves.Remove(save);
            await _context.SaveChangesAsync();


            return true;
        }
    }
}
