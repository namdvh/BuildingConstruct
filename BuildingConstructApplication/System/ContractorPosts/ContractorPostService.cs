using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Text;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.Users;


namespace Application.System.ContractorPosts
{
    public class ContractorPostService : IContractorPostService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        public ContractorPostService(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<bool> CreateContractorPost(ContractorPostModels contractorPostDTO)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value;
            var contracID = _context.Users.Where(x => x.Id.ToString().Equals(userID)).FirstOrDefault().ContractorId;

            var contractorPost = new ContractorPost
            {
                Title = contractorPostDTO.Title,
                ProjectName = contractorPostDTO.ProjectName,
                Description = contractorPostDTO.Description,
                StarDate = contractorPostDTO.StarDate,
                EndDate = contractorPostDTO.EndDate,
                ConstructionType= contractorPostDTO.ConstructionType,
                StartTime= contractorPostDTO.StartTime,
                EndTime=contractorPostDTO.EndTime,
                Accommodation= contractorPostDTO.Accommodation,
                Transport=contractorPostDTO.Transport,
                Place = contractorPostDTO.Place,
                Salaries = contractorPostDTO.Salaries,
                ViewCount = 0,
                NumberPeople = contractorPostDTO.NumberPeople,
                PeopeRemained = contractorPostDTO.NumberPeople,
                Status = Status.Level1,
                PostCategories = PostCategories.Categories1,
                Benefit=contractorPostDTO.Benefit,
                Required=contractorPostDTO.Required,
                LastModifiedAt = DateTime.Now,
                CreateBy = Guid.Parse(userID),
                ContractorID = (int)contracID

            };

            await _context.ContractorPosts.AddAsync(contractorPost);
            await _context.SaveChangesAsync();
            //first
            var id = contractorPost.Id;
            var type = contractorPostDTO.type;
            foreach (var item in type)
            {
                var rType = new Data.Entities.ContractorPostType();
                if (item.id != null)
                {
                    rType.TypeID = (Guid)item.id;
                    rType.ContractorPostID = id;
                    _context.ContractorPostTypes.Add(rType);
                    var rs = _context.SaveChanges();
                    if (rs < 0)
                    {
                        _context.Remove(contractorPost);
                        return false;

                    }
                }
            }

            var flag = false;
            foreach (var i in type)
            {
                foreach (var o in i.SkillArr)
                {

                    if (o.fromSystem == false)
                    {
                        var rSkill = new Skill();
                        rSkill.Name = o.name;
                        rSkill.FromSystem = o.fromSystem;
                        _context.Skills.Add(rSkill);
                        _context.SaveChanges();



                        var cPostSkill = new ContractorPostSkill();
                        cPostSkill.ContractorPostID = id;
                        cPostSkill.SkillID = rSkill.Id;
                        _context.ContractorPostSkills.Add(cPostSkill);
                        var rs = _context.SaveChanges();
                        if (rs < 0)
                        {
                            _context.Remove(contractorPost);
                            return false;
                        }
                        flag = true;
                    }
                    else
                    {
                        var rs = await _context.Skills.Include(x => x.Type).Where(x => x.Id == o.id).ToListAsync();
                        foreach (var c in rs)
                        {
                            var guid = i.id.ToString();
                            var cid = c.TypeId.ToString();
                            if (guid.Equals(cid))
                            {

                                var cPostSkill = new ContractorPostSkill();
                                cPostSkill.ContractorPostID = id;
                                cPostSkill.SkillID = o.id;
                                _context.ContractorPostSkills.Add(cPostSkill);
                                _context.SaveChanges();
                                flag = true;
                            }
                            else
                            {
                                _context.ContractorPosts.Remove(contractorPost);
                                _context.SaveChanges();
                                return false;
                            }
                        }
                    }
                }

            };
            await _context.SaveChangesAsync();
            if (flag)
            {
                return true;
            }
            return false;
        }

        public async Task<BaseResponse<ContractorPostDetailDTO>> GetDetailPost(int cPostid)
        {
            var rs = await _context.ContractorPosts.FirstOrDefaultAsync(x => x.Id == cPostid);
            BaseResponse<ContractorPostDetailDTO> response = new();


            if (rs == null)
            {

                response.Code = BaseCode.ERROR;
                response.Message = "Cannot find that Post";
                return response;
            }
            var count = await _context.ContractorPosts.Where(x => x.Id == cPostid).ToListAsync();
            foreach (var item in count)
            {
                int view = item.ViewCount;
                view++;
                item.ViewCount = view;
                _context.ContractorPosts.Update(item);
                await _context.SaveChangesAsync();
            }
            ContractorPostDetailDTO postDetail = await MapToDetailDTO(rs);
            response.Data = postDetail;
            response.Code = BaseCode.SUCCESS;
            response.Message = "SUCCESS";
            return response;
        }
        private async Task<ContractorPostDetailDTO> MapToDetailDTO(ContractorPost post)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            bool IsSave = false;
            var save = await _context.Saves.Where(x => x.UserId.ToString().Equals(userID) && x.ContractorPostId == post.Id).FirstOrDefaultAsync();
            if (save != null)
            {
                IsSave = true;
            }
            var check = await _context.AppliedPosts.Where(x => x.BuilderID.ToString().Equals(userID) && x.PostID.Equals(post.Id)).ToListAsync();
            if (check.Any())
            {
                post.isApplied = true;
            }
            else
            {
                post.isApplied = false;
            }
            ContractorPostDetailDTO postDTO = new()
            {
                Title = post.Title,
                Accommodation=post.Accommodation,
                ConstructionType=post.ConstructionType,
                EndTime=post.EndTime,
                StartTime=post.StartTime,
                Transport=post.Transport,
                ProjectName = post.ProjectName,
                Salaries = post.Salaries,
                Description = post.Description,
                Benefit=post.Benefit,
                Required=post.Required,
                StarDate = post.StarDate,
                EndDate = post.EndDate,
                LastModifiedAt = post.LastModifiedAt,
                NumberPeople = post.NumberPeople,
                PeopleRemained = post.PeopeRemained,
                PostCategories = post.PostCategories,
                Place = post.Place,
                IsApplied =post.isApplied,
                type = await GetTypeAndSkillFromPost(post.Id),
                CreatedBy = post.CreateBy,
                Author = await GetUserProfile(post.CreateBy),
                IsSave=IsSave
            };

            return postDTO;
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
                
                foreach (var i in rsSkill.Where(x => x.Skills.TypeId == null).ToList())
                {
                    var t = new TypeModels();
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
  
        public async Task<BasePagination<List<ContractorPostDTO>>> GetPost(PaginationFilter filter,Guid id)
        {
            BasePagination<List<ContractorPostDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<ContractorPost> query = _context.ContractorPosts;
            StringBuilder salariesSearch = new();
            StringBuilder placeSearch = new();
            StringBuilder categoriesSearch = new();

            if (filter.FilterRequest != null)
            {
                if (filter.FilterRequest.Salary.Any())
                {
                    var count = filter.FilterRequest.Salary.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            salariesSearch.Append("Salaries=*" + filter.FilterRequest.Salary[i]);
                            break;
                        }
                        salariesSearch.Append("Salaries=*" + filter.FilterRequest.Salary[i] + "|");
                    }
                    query = query.ApplyFiltering(salariesSearch.ToString());
                }

                if (filter.FilterRequest.Places.Any())
                {
                    var count = filter.FilterRequest.Places.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            placeSearch.Append("Place=" + filter.FilterRequest.Places[i]);
                            break;
                        }
                        placeSearch.Append("Place=" + filter.FilterRequest.Places[i] + "|");
                    }
                    query = query.ApplyFiltering(placeSearch.ToString());
                }

                if (filter.FilterRequest.Categories.Any())
                {
                    var count = filter.FilterRequest.Categories.Count;
                    for (int i = 0; i < count; i++)
                    {
                        if (i == count - 1)
                        {
                            categoriesSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i]);
                            break;
                        }
                        categoriesSearch.Append("PostCategories=" + filter.FilterRequest.Categories[i] + "|");
                    }
                    query = query.ApplyFiltering(categoriesSearch.ToString());
                }

                if (filter.FilterRequest.Participant.HasValue)
                {
                    query = query.Where(x => x.NumberPeople == filter.FilterRequest.Participant);
                }

                if (!string.IsNullOrEmpty(filter.FilterRequest.Title))
                {
                    query = query.Include(x => x.Contractor).Where(x => x.Title.Contains(filter.FilterRequest.Title) || x.Contractor.CompanyName.Contains(filter.FilterRequest.Title));
                }
                if (filter.FilterRequest.Transport == true)
                {
                    query = query.Where(x => x.Transport == true);

                }
                if (filter.FilterRequest.Accommodation == true)
                {
                    query = query.Where(x => x.Accommodation == true);

                }

            }

            var result = await query
                    .Include(x=>x.Contractor)
                        .ThenInclude(x=>x.User)
                     .OrderBy(filter._sortBy + " " + orderBy)
                     .Skip((filter.PageNumber - 1) * filter.PageSize)
                     .Take(filter.PageSize)
                     .ToListAsync();


            if (filter.FilterRequest != null)
            {
                totalRecord = result.Count;
            }
            else
            {
                totalRecord = await _context.ContractorPosts.CountAsync();
            }

            if (!result.Any())
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

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(result,id),
                    Pagination = pagination
                };
            }
            return response;
        }



        public async Task<BasePagination<List<AppliedPostDTO>>> ViewAppliedPost(int postID, PaginationFilter filter)
        {
            BasePagination<List<AppliedPostDTO>> response;
            var orderBy = filter._orderBy.ToString();

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "PostID";
            }


            var appliedPost = await _context.AppliedPosts
                .Include(x => x.Builder)
                    .ThenInclude(x => x.User)
                .Where(x => x.PostID == postID)
                .OrderBy(filter._sortBy + " " + orderBy)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .AsNoTracking()
                .ToListAsync();


            if (!appliedPost.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
                };
                return response;
            }

            var totalRecord = await _context.AppliedPosts.Where(x => x.PostID == postID).CountAsync();

            List<AppliedPostDTO> appliedPostDTOs = new();
            foreach (var x in appliedPost)
            {
                var flag = await _context.Groups.Where(group => group.BuilderID == x.BuilderID && group.PostID == postID).FirstOrDefaultAsync();
                if (flag == null)
                {
                    appliedPostDTOs.Add(MapToAppliedPostDTO(x));
                }
                else
                {
                    var groups = await _context.GroupMembers.Where(x => x.GroupId == flag.Id).ToListAsync();
                    appliedPostDTOs.Add(MapToAppliedPostGroupDTO(x, groups));
                }

            }
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

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE,
                Data = appliedPostDTOs,
                Pagination = pagination
            };

            return response;
        }


        private AppliedPostDTO MapToAppliedPostDTO(AppliedPost applied)
        {
            AppliedPostDTO rs = new()
            {
                Avatar = applied.Builder.User.Avatar,
                BuilderID = applied.BuilderID,
                FirstName = applied.Builder.User.FirstName,
                LastName = applied.Builder.User.LastName,
                UserID = applied.Builder.User.Id,
                WishSalary=applied.WishSalary,
                AppliedDate = applied.AppliedDate
            };
            return rs;
        }

        private AppliedPostDTO MapToAppliedPostGroupDTO(AppliedPost applied, List<GroupMember> groupMember)
        {
            List<AppliedGroup> group = MapGroup(groupMember);

            AppliedPostDTO rs = new()
            {
                Avatar = applied.Builder.User.Avatar,
                BuilderID = applied.BuilderID,
                FirstName = applied.Builder.User.FirstName,
                LastName = applied.Builder.User.LastName,
                UserID = applied.Builder.User.Id,
                WishSalary=applied.WishSalary,
                Groups = group,
                AppliedDate = applied.AppliedDate
            };
            return rs;
        }
        private List<AppliedGroup> MapGroup(List<GroupMember> groupMembers)
        {
            List<AppliedGroup> result = new();

            foreach (var item in groupMembers)
            {
                AppliedGroup rs = new()
                {
                    DOB = item.DOB,
                    VerifyId = item.IdNumber,
                    Name = item.Name,
                    TypeID = item.TypeID,
                };
                result.Add(rs);
            }
            return result;

        }
        public async Task<BasePagination<List<ContractorPostDTO>>> GetPostByViews(PaginationFilter filter)
        {

            BasePagination<List<ContractorPostDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            var result = await _context.ContractorPosts
                           .OrderBy("Views" + " " + orderBy)
                           .Skip((filter.PageNumber - 1) * filter.PageSize)
                           .Take(filter.PageSize)
                           .ToListAsync();

            totalRecord = await _context.ContractorPosts.CountAsync();


            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new(),
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

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
        }

        public async Task<BasePagination<List<ContractorPostDTO>>> SearchPost(PaginationFilter filter, string keyword)
        {
            BasePagination<List<ContractorPostDTO>> response;

            var result = await _context.ContractorPosts.Include(x => x.Contractor).Where(x => x.Title.Contains(keyword) || x.Contractor.CompanyName.Contains(keyword)).ToListAsync();
            var totalRecord = result.Count;

            if (!result.Any())
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

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
        }

        private List<ContractorPostDTO> MapListDTO(List<ContractorPost> list,Guid id)
        {
            List<ContractorPostDTO> result = new();

            foreach (var item in list)
            {
                //var user = _context.Users.Where(x => x.ContractorId.Equals(item.ContractorID)).FirstOrDefault();
                var isSaved = _context.Saves.Where(x => x.ContractorPostId == item.Id && x.UserId.Equals(id)).FirstOrDefault();
                bool save = false;
                if (isSaved != null)
                {
                    save = true;
                }


                ContractorPostDTO dto = new()
                {
                    Avatar = item.Contractor.User.Avatar,
                    ContractorID = item.ContractorID,
                    Description = item.Description,
                    EndDate = item.EndDate,
                    Id = item.Id,
                    NumberPeople = item.NumberPeople,
                    Place = item.Place,
                    PostCategories = item.PostCategories,
                    ProjectName = item.ProjectName,
                    Salaries = item.Salaries,
                    StarDate = item.StarDate,
                    AuthorName = item.Contractor.User.FirstName + " " + item.Contractor.User.LastName,
                    Title = item.Title,
                    IsSave = save,
                    ViewCount = item.ViewCount,
                    LastModifiedAt = item.LastModifiedAt,
                };
                result.Add(dto);
            }
            return result;
        }

        private List<ContractorPostDTO> MapListDTO(List<ContractorPost> list)
        {
            List<ContractorPostDTO> result = new();

            foreach (var item in list)
            {
                //var user = _context.Users.Where(x => x.ContractorId.Equals(item.ContractorID)).FirstOrDefault();
                


                ContractorPostDTO dto = new()
                {
                    Avatar = item.Contractor.User.Avatar,
                    ContractorID = item.ContractorID,
                    Description = item.Description,
                    EndDate = item.EndDate,
                    Id = item.Id,
                    NumberPeople = item.NumberPeople,
                    Place = item.Place,
                    PostCategories = item.PostCategories,
                    ProjectName = item.ProjectName,
                    Salaries = item.Salaries,
                    StarDate = item.StarDate,
                    AuthorName = item.Contractor.User.FirstName + " " + item.Contractor.User.LastName,
                    Title = item.Title,
                    ViewCount = item.ViewCount,
                    LastModifiedAt = item.LastModifiedAt,
                };
                result.Add(dto);
            }
            return result;
        }

        public async Task<BaseResponse<string>> AppliedPost(AppliedPostRequest request, Guid userID)
        {
            BaseResponse<string> response;



            var user = await _context.Users.Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();
            var alreadyApplied = await _context.AppliedPosts.Where(x => x.BuilderID == user.BuilderId && x.PostID == request.PostId).FirstOrDefaultAsync();

            if (alreadyApplied != null)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = "You have already applied to the post"
                };
                return response;
            }

            //Group is not null
            if (request.GroupMember is not null)
            {
                Group group = new()
                {
                    BuilderID = user.BuilderId.Value,
                    PostID = request.PostId
                };

                await _context.Groups.AddAsync(group);
                await _context.SaveChangesAsync();

                foreach (var item in request.GroupMember)
                {
                    GroupMember groupMember = new()
                    {
                        DOB = item.DOB,
                        IdNumber = item.VerifyId,
                        Name = item.Name,
                        TypeID = item.TypeID,
                        GroupId = group.Id
                    };

                    await _context.GroupMembers.AddAsync(groupMember);
                    await _context.SaveChangesAsync();
                }

                AppliedPost applied = new()
                {
                    BuilderID = user.BuilderId.Value,
                    PostID = request.PostId,
                    WishSalary=request.WishSalary,
                    GroupID = group.Id,
                    Status = Status.NOT_RESPONSE,
                    AppliedDate = DateTime.Now
                };

                await _context.AppliedPosts.AddAsync(applied);
                await _context.SaveChangesAsync();

            }
            else
            {
                AppliedPost applied = new()
                {
                    BuilderID = user.BuilderId.Value,
                    PostID = request.PostId,
                    WishSalary=request.WishSalary,
                    Status = Status.NOT_RESPONSE,
                    AppliedDate = DateTime.Now

                };

                await _context.AppliedPosts.AddAsync(applied);
                await _context.SaveChangesAsync();
            }


            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE,

            };

            return response;
        }
    }
}