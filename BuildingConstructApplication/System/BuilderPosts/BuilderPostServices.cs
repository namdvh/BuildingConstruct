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
using ViewModels.Pagination;
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
            var builderID = _context.Users.Where(x => x.Id.ToString().Equals(userID)).FirstOrDefault().BuilderId;
            var builderPost = new BuilderPost
            {
                Title = builderPostDTO.Title,
                PostCategories = builderPostDTO.PostCategories,
                Place = builderPostDTO.Place,
                Description = builderPostDTO.Description,
                Views = 0,
                Field = builderPostDTO.Field,
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
                    _context.SaveChanges();
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
                        _context.SaveChanges();
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

                if (string.IsNullOrEmpty(filter.FilterRequest.Title))
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
                    Field = item.Field,
                };
                result.Add(dto);
            }
            return result;
        }
    }
}