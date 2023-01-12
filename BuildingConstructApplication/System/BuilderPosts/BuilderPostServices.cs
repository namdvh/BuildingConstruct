using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Text;
using ViewModels.BuilderPosts;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;
using ViewModels.Users;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Application.System.BuilderPosts
{
    public class BuilderPostServices : IBuilderPostService
    {
        private readonly BuildingConstructDbContext _context;
        private IHttpContextAccessor _accessor;
        public BuilderPostServices(BuildingConstructDbContext context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public async Task<bool> CreateBuilderPost(BuilderPostRequestDTO builderPostDTO)
        {

            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value;
            var builderID =  _context.Users.Where(x => x.Id.ToString().Equals(userID.ToString())).FirstOrDefault().BuilderId;
            var builderPost = new BuilderPost
            {
                Title = builderPostDTO.Title,
                PostCategories = builderPostDTO.PostCategories,
                Place = builderPostDTO.Place,
                Description = builderPostDTO.Description,
                Views = 0,
                Salaries = builderPostDTO.Salaries,
                Status = Status.Level1,
                BuilderID = (int)builderID,
                CreateBy = Guid.Parse(userID),
                LastModifiedAt = DateTime.Now
            };

            await _context.BuilderPosts.AddAsync(builderPost);
            await _context.SaveChangesAsync();
            var id = builderPost.Id;
            var type = builderPostDTO.type;
            foreach (var item in type)
            {
                var rType = new Data.Entities.BuilderPostType();
                if (item.id != null)
                {
                    rType.TypeID = (Guid)item.id;
                    rType.BuilderPostID = id;
                    _context.BuilderPostTypes.Add(rType);
                    var rs = _context.SaveChanges();
                    //second
                    if (rs < 0)
                    {
                        _context.Remove(builderPost);
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

                        var bPostSkill = new BuilderPostSkill();
                        bPostSkill.BuilderPostID = id;
                        bPostSkill.SkillID = rSkill.Id;
                        _context.BuilderPostSkills.Add(bPostSkill);
                        var rs = _context.SaveChanges();

                        if (rs < 0)
                        {
                            _context.Remove(builderPost);
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

                                var bPostSkill = new BuilderPostSkill();
                                bPostSkill.BuilderPostID = id;
                                bPostSkill.SkillID = o.id;
                                _context.BuilderPostSkills.Add(bPostSkill);
                                _context.SaveChanges();

                                flag = true;
                            }
                            else
                            {
                                _context.BuilderPosts.Remove(builderPost);
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

        public async Task<BaseResponse<BuilderPostDetailDTO>> GetDetailPost(int bPostid)
        {
            var rs = await _context.BuilderPosts.FirstOrDefaultAsync(x => x.Id == bPostid);
            BaseResponse<BuilderPostDetailDTO> response = new();

            if (rs == null)
            {
                response.Code = BaseCode.ERROR;
                response.Message = "Cannot find that Post";
                return response;
            }
            var count = await _context.BuilderPosts.Where(x => x.Id == bPostid).ToListAsync();
            foreach (var item in count)
            {
                int view = item.Views;
                view++;
                item.Views = view;
                _context.BuilderPosts.Update(item);
                await _context.SaveChangesAsync();
            }
            BuilderPostDetailDTO postDetail = await MapToDetailDTO(rs);
            response.Data = postDetail;
            response.Code = BaseCode.SUCCESS;
            response.Message = "SUCCESS";
            return response;
        }
        private async Task<BuilderPostDetailDTO> MapToDetailDTO(BuilderPost post)
        {
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst("UserID");
            var userID = identifierClaim.Value.ToString();
            var product = await _context.BuilderPosts.Where(x => x.BuilderID == post.Id).ToListAsync();
            bool IsSave = false;
            var save = await _context.Saves.Where(x => x.UserId.ToString().Equals(userID.ToString()) && x.BuilderPostId == post.Id).ToListAsync();
            if (save.Any())
            {
                IsSave = true;
            }
            BuilderPostDetailDTO postDTO = new()
            {
                Title = post.Title,
                Id = post.Id,
                Salaries = post.Salaries,
                Description = post.Description,
                Status = post.Status,
                LastModifiedAt = post.LastModifiedAt,
                PostCategories = post.PostCategories,
                Place = post.Place,
                type = await GetTypeAndSkillFromPost(post.Id),
                IsSave=IsSave,
                CreatedBy = post.CreateBy,
                Author = await GetUserProfile(post.CreateBy)
            };

            return postDTO;
        }
        private async Task<List<TypeModels>> GetTypeAndSkillFromPost(int postID)
        {
            var results = await _context.BuilderPostTypes.Include(x => x.Types).Where(x => x.BuilderPostID == postID).ToListAsync();
            var rsSkill = await _context.BuilderPostSkills.Include(x => x.Skills).Where(x => x.BuilderPostID == postID).ToListAsync();
            var final = new List<TypeModels>();
            foreach (var item in results)
            {
                var type = new TypeModels();
                type.id = item.TypeID;
                type.name = item.Types.Name;
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
        private async Task<UserModelsDTO> GetUserProfile(Guid userID)
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
        public async Task<BasePagination<List<BuilderPostDTO>>> GetPost(PaginationFilter filter)
        {
            BasePagination<List<BuilderPostDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };

            IQueryable<BuilderPost> query = _context.BuilderPosts;
            StringBuilder placeSearch = new();
            StringBuilder categoriesSearch = new();

            if (filter.FilterRequest != null)
            {
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

                if (!string.IsNullOrEmpty(filter.FilterRequest.Title))
                {
                    query = query.Where(x => x.Title.Contains(filter.FilterRequest.Title));
                }
            }

            var result = await query
               .OrderBy(filter._orderBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();

            if (filter.FilterRequest != null)
            {
                totalRecord = result.Count;
            }
            else
            {
                totalRecord = await _context.BuilderPosts.CountAsync();
            }

            if (!result.Any())
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.EMPTY_MESSAGE,
                    Data = new List<BuilderPostDTO>(),
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

        public async Task<BasePagination<List<BuilderPostDTO>>> GetPostByViews(PaginationFilter filter)
        {
            BasePagination<List<BuilderPostDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            var result = await _context.BuilderPosts
                           .OrderBy("Views" + " " + orderBy)
                           .Skip((filter.PageNumber - 1) * filter.PageSize)
                           .Take(filter.PageSize)
                           .ToListAsync();

            totalRecord = await _context.BuilderPosts.CountAsync();


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

        public async Task<BasePagination<List<BuilderPostDTO>>> SearchPost(PaginationFilter filter, string keyword)
        {
            BasePagination<List<BuilderPostDTO>> response;

            var result = await _context.BuilderPosts.Where(x => x.Title.Contains(keyword)).ToListAsync();
            var totalRecord = result.Count;

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

        private List<BuilderPostDTO> MapListDTO(List<BuilderPost> list)
        {
            List<BuilderPostDTO> result = new();

            foreach (var item in list)
            {
                var user = _context.Users.Where(x => x.BuilderId == item.BuilderID).FirstOrDefault();

                BuilderPostDTO dto = new()
                {
                    //Avatar = user.Avatar,
                    Description = item.Description,
                    Id = item.Id,
                    Place = item.Place,
                    PostCategories = item.PostCategories,
                    Title = item.Title,
                    LastModifiedAt = item.LastModifiedAt,
                    BuilderID = item.BuilderID,
                };
                result.Add(dto);
            }
            return result;
        }
    }
}