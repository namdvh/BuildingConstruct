using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;
using System.Security.Claims;
using System.Text;
using ViewModels.BuilderPosts;
using ViewModels.Commitment;
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
            Claim identifierClaim = _accessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            var userID = identifierClaim.Value;
            var contracID = _context.Users.Where(x => x.Id.ToString().Equals(userID)).FirstOrDefault().ContractorId;

            var contractorPost = new ContractorPost
            {
                Title = contractorPostDTO.Title,
                ProjectName = contractorPostDTO.ProjectName,
                Description = contractorPostDTO.Description,
                StarDate = contractorPostDTO.StarDate,
                EndDate = contractorPostDTO.EndDate,
                Place = contractorPostDTO.Place,
                Salaries = contractorPostDTO.Salaries,
                ViewCount = 0,
                NumberPeople = contractorPostDTO.NumberPeople,
                PeopeRemained = contractorPostDTO.NumberPeople,
                Status = Status.Level1,
                PostCategories = PostCategories.Categories1,
                LastModifiedAt = DateTime.Now,
                CreateBy = Guid.Parse(userID),
                ContractorID = (int)contracID

            };

            await _context.ContractorPosts.AddAsync(contractorPost);
            await _context.SaveChangesAsync();
            var id = contractorPost.Id;
            var cPostProduct = new ContractorPostProduct();
            foreach (var item in contractorPostDTO.ProductSystemId)
            {
                cPostProduct.ProductSystemID = item;
                cPostProduct.ContractorPostID = contractorPost.Id;
                _context.ContractorPostProducts.Add(cPostProduct);
                _context.SaveChanges();
            }
            var type = contractorPostDTO.type;
            foreach (var item in type)
            {
                var rType = new Data.Entities.ContractorPostType();
                if (item.id != null)
                {
                    rType.TypeID = (Guid)item.id;
                    rType.ContractorPostID = id;
                    _context.ContractorPostTypes.Add(rType);
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
                        var cPostSkill = new ContractorPostSkill();
                        cPostSkill.ContractorPostID = id;
                        cPostSkill.SkillID = rSkill.Id;
                        _context.ContractorPostSkills.Add(cPostSkill);
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

            var result = await query
               .OrderBy(filter._sortBy + " " + orderBy)
               .Skip((filter.PageNumber - 1) * filter.PageSize)
               .Take(filter.PageSize)
               .ToListAsync();

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
            var product = await _context.ContractorPostProducts.Include(x => x.ProductSystem).Where(x => x.ContractorPostID == post.Id).Select(x => x.ProductSystemID).ToListAsync();
            var userId = await _context.ContractorPostProducts.Include(x => x.ContractorPost).Where(x => x.ContractorPostID == post.Id).Select(x => x.ContractorPost.CreateBy).FirstOrDefaultAsync();
            ContractorPostDetailDTO postDTO = new()
            {
                Title = post.Title,
                ProjectName = post.ProjectName,
                Salaries = post.Salaries,
                Description = post.Description,
                ProductSystem = await GetProductFromPost(post.Id),
                StarDate = post.StarDate,
                EndDate = post.EndDate,
                LastModifiedAt = post.LastModifiedAt,
                NumberPeople = post.NumberPeople,
                PeopleRemained = post.PeopeRemained,
                PostCategories = post.PostCategories,
                Place = post.Place,
                type = await GetTypeAndSkillFromPost(post.Id),
                CreatedBy = userId,
                User = await GetUserProfile(userId)
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
            var results = await _context.Users.Where(x => x.Id.Equals(userID)).SingleOrDefaultAsync();
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
        private async Task<List<ContractorPostProductDTO>> GetProductFromPost(int postID)
        {
            var results = await _context.ContractorPostProducts.Include(x => x.ProductSystem).Where(x => x.ContractorPostID == postID).ToListAsync();
            var query = from cP in _context.ContractorPostProducts
                        join pSys in _context.ProductSystems on cP.ProductSystemID equals pSys.Id into rs1
                        from r in rs1.DefaultIfEmpty()
                        join cat in _context.ProductSystemCategories on r.Id equals cat.ProductSystemID into rs2
                        from r1 in rs2.DefaultIfEmpty()
                        join c in _context.Categories on r1.CategoriesID equals c.ID into rs3
                        from r3 in rs3.DefaultIfEmpty()
                        where cP.ContractorPostID == postID
                        select new
                        {
                            ProductSystemCategories = r1,
                            ProductSystem = r,
                            Categories=r3
                        };
            var result = await query.AsNoTracking().ToListAsync();
        var final = new List<ContractorPostProductDTO>();

            foreach (var x in result)
            {
                ContractorPostProductDTO dto = new();
                dto.Id = x.ProductSystem.Id;
                dto.Name = x.ProductSystem.Name;
                dto.Brand = x.ProductSystem.Brand;
                dto.Description = x.ProductSystem.Description;
                dto.Categories = x.Categories;
                final.Add(dto);
            }
            return final;
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
                var flag = await _context.Groups.Where(group => group.BuilderID == x.BuilderID && group.PostID == postID).FirstOrDefaultAsync();
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

private List<ContractorPostDTO> MapListDTO(List<ContractorPost> list)
{
    List<ContractorPostDTO> result = new();

    foreach (var item in list)
    {
        var user = _context.Users.Where(x => x.ContractorId.Equals(item.ContractorID)).FirstOrDefault();

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

    }
}