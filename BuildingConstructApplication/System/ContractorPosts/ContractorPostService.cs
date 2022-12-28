using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ViewModels.BuilderPosts;
using ViewModels.Commitment;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.ContractorPosts
{
    public class ContractorPostService : IContractorPostService
    {
        private readonly BuildingConstructDbContext _context;

        public ContractorPostService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BasePagination<List<ContractorPostDTO>>> GetPost(PaginationFilter filter)
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

                if (string.IsNullOrEmpty(filter.FilterRequest.Title))
                {
                    query = query.Include(x => x.Contractor).Where(x => x.Title.Contains(filter.FilterRequest.Title) || x.Contractor.CompanyName.Contains(filter.FilterRequest.Title));
                }
            }

            var result = await query
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
                    Data = MapListDTO(result),
                    Pagination = pagination
                };
            }
            return response;
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

        public async Task<BaseResponse<string>> AppliedPost(AppliedPostRequest request, Guid userID)
        {
            BaseResponse<string> response;



            var user = await _context.Users.Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();
            var alreadyApplied = await _context.AppliedPosts.Where(x => x.BuilderID == user.BuilderId && x.PostID == request.PostId).FirstOrDefaultAsync();

            if(alreadyApplied != null)
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
                    GroupID = group.Id,
                    Status = Status.NOT_RESPONSE,
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
                    Status = Status.NOT_RESPONSE,
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

        private List<ContractorPostDTO> MapListDTO(List<ContractorPost> list)
        {
            List<ContractorPostDTO> result = new();

            foreach (var item in list)
            {
                var user = _context.Users.Where(x => x.ContractorId == item.ContractorID).FirstOrDefault();

                ContractorPostDTO dto = new()
                {
                    //Avatar = user.Avatar,
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
                    Title = item.Title,
                    ViewCount = item.ViewCount,
                    LastModifiedAt = item.LastModifiedAt,
                };
                result.Add(dto);
            }
            return result;
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
                var flag = await _context.Groups.Where(x => x.BuilderID == x.BuilderID && x.PostID == postID).FirstOrDefaultAsync();
                if (flag == null)
                {
                    appliedPostDTOs.Add(MapToAppliedPostDTO(x));
                }
                else
                {
                    var groups = await _context.GroupMembers.Where(x => x.GroupId == flag.Id).ToListAsync();
                    appliedPostDTOs.Add( MapToAppliedPostGroupDTO(x, groups));
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
                Pagination=pagination
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
                UserID = applied.Builder.User.Id
            };
            return rs;
        }

        private  AppliedPostDTO MapToAppliedPostGroupDTO(AppliedPost applied, List<GroupMember> groupMember)
        {
            List<AppliedGroup> group = MapGroup(groupMember);

            AppliedPostDTO rs = new()
            {
                Avatar = applied.Builder.User.Avatar,
                BuilderID = applied.BuilderID,
                FirstName = applied.Builder.User.FirstName,
                LastName = applied.Builder.User.LastName,
                UserID = applied.Builder.User.Id,
                Groups = group
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
    }
}