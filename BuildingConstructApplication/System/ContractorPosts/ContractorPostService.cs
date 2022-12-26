using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Gridify;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Text;
using ViewModels.BuilderPosts;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

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
            foreach (var item in contractorPostDTO.ProductId)
            {
                cPostProduct.ProductID = item;
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
                    rType.TypeID = (int)item.id;
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
                        var rs = await _context.Skills.Include(x => x.Type).Where(x=>x.Id==o.id).ToListAsync();
                        foreach(var c in rs)
                        {
                            if (i.id == c.TypeId)
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
            foreach(var item in count)
            {
                int view = item.ViewCount;
                view++;
                item.ViewCount = view;
                 _context.ContractorPosts.Update(item);
                await _context.SaveChangesAsync();
            }
            ContractorPostDetailDTO postDetail =await MapToDetailDTO(rs);
            response.Data = postDetail;
            response.Code = BaseCode.SUCCESS;
            response.Message = "SUCCESS";
            return response;
        }
        private async Task<ContractorPostDetailDTO> MapToDetailDTO(ContractorPost post)
        {
            var product =await _context.ContractorPostProducts.Include(x => x.Products).Where(x => x.ContractorPostID == post.Id).Select(x => x.ProductID).ToListAsync();
            var userId =await _context.ContractorPostProducts.Include(x => x.ContractorPost).Where(x => x.ContractorPostID == post.Id).Select(x => x.ContractorPost.CreateBy).FirstOrDefaultAsync();
            ContractorPostDetailDTO postDTO = new()
            {
                Title = post.Title,
                ProjectName = post.ProjectName,
                Salaries = post.Salaries,
                Description = post.Description,
                Products = await GetProductFromPost(post.Id),
                StarDate = post.StarDate,
                EndDate = post.EndDate,
                LastModifiedAt = post.LastModifiedAt,
                NumberPeople = post.NumberPeople,
                PeopleRemained = post.PeopeRemained,
                PostCategories = post.PostCategories,
                Place = post.Place,
                type = await GetTypeAndSkillFromPost(post.Id),
                CreatedBy = userId
            };

            return postDTO;
        }
        private async Task<List<TypeModels>> GetTypeAndSkillFromPost(int postID)
        {
            var results =await _context.ContractorPostTypes.Include(x => x.Type).Where(x => x.ContractorPostID == postID).ToListAsync();
            var rsSkill =await _context.ContractorPostSkills.Include(x => x.Skills).Where(x => x.ContractorPostID == postID).ToListAsync();
            var final = new List<TypeModels>();
            foreach(var item in results)
            {
                var type = new TypeModels();
                type.id = item.TypeID;
                type.name = item.Type.Name;
                type.SkillArr = new();
                foreach (var i in rsSkill)
                {
                    if (i.Skills.TypeId == item.TypeID)
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
        private async Task<List<ContractorPostProductDTO>> GetProductFromPost(int postID)
        {
            var results =await _context.ContractorPostProducts.Include(x => x.Products).Where(x => x.ContractorPostID == postID).ToListAsync();

            var final = new List<ContractorPostProductDTO>();

            foreach (var x in results)
            {
                ContractorPostProductDTO dto = new();
                dto.Id = x.ProductID;
                dto.Name = x.Products.Name;
                dto.Brand = x.Products.Brand;
                dto.Description = x.Products.Description;
                dto.UnitPrice = x.Products.UnitPrice;
                dto.UnitInStock = x.Products.UnitInStock;
                dto.MaterialStore = x.Products.MaterialStore;
                dto.ProductCategories = x.Products.ProductCategories;
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