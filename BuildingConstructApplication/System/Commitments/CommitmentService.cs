using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using ViewModels.Commitment;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.Commitments
{
    public class CommitmentService : ICommitmentService
    {
        private readonly BuildingConstructDbContext _context;
        private readonly UserManager<User> _userService;


        public CommitmentService(BuildingConstructDbContext context, UserManager<User> userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<BasePagination<List<CommitmentDTO>>> GetCommitment(Guid UserID, PaginationFilter filter, Status status)
        {
            BasePagination<List<CommitmentDTO>> response;

            var orderBy = filter._orderBy.ToString();
            int totalRecord = 0;
            List<PostCommitment>? result = new();

            IQueryable<PostCommitment> query = _context.PostCommitments;
            IQueryable<PostCommitment> count = _context.PostCommitments;


            if (status == Status.SUCCESS)
            {
                query = query.Where(x => x.Status == Status.SUCCESS);
                count = count.Where(x => x.Status == Status.SUCCESS);
            }
            else
            {
                query = query.Where(x => x.Status == Status.NOT_RESPONSE);
                count = count.Where(x => x.Status == Status.NOT_RESPONSE);

            }

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

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id.Equals(UserID));


            var rolename = _userService.GetRolesAsync(user).Result;


            if (rolename.First().Equals("User"))
            {
                result = await query
                         .Include(x => x.ContractorPosts)
                         .Include(x => x.Builder)
                                    .ThenInclude(x => x.User)
                         .Include(x => x.Builder)
                            .ThenInclude(x => x.Type)
                         .Where(x => (x.BuilderID.Equals(user.BuilderId)))
                         .OrderBy(filter._sortBy + " " + orderBy)
                         .Skip((filter.PageNumber - 1) * filter.PageSize)
                         .Take(filter.PageSize)
                         .ToListAsync();

                totalRecord = await count.Where(x => (x.BuilderID.Equals(user.BuilderId))).CountAsync();


            }
            else if (rolename.First().Equals("Contractor"))
            {
                result = await query
                        .Include(x => x.ContractorPosts)
                            .Include(x => x.Contractor)
                                .ThenInclude(x => x.User)
                        .Include(x => x.Builder)
                            .ThenInclude(x => x.Type)
                        .Include(x => x.Builder)
                            .ThenInclude(x => x.User)
                        .Where(x => (x.ContractorID.Equals(user.ContractorId)))
                        .OrderBy(filter._sortBy + " " + orderBy)
                        .Skip((filter.PageNumber - 1) * filter.PageSize)
                        .Take(filter.PageSize)
                        .ToListAsync();

                totalRecord = await count.Where(x => (x.ContractorID.Equals(user.ContractorId))).CountAsync();


            }



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

        public async Task<BaseResponse<DetailCommitmentDTO>> GetDetailCommitment(int id)
        {
            BaseResponse<DetailCommitmentDTO> response;
            List<DetailCommitmentDTO> ls = new();

            var result = await _context.PostCommitments
                .Include(x => x.ContractorPosts)
                .Include(x => x.Contractor)
                    .ThenInclude(x => x.User)
                .Include(x => x.Builder)
                    .ThenInclude(x => x.User)
                .Include(x => x.Builder)
                    .ThenInclude(x => x.Type)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();


            var flag = await _context.Groups.Where(x => x.BuilderID == result.BuilderID && x.PostID == result.PostID).FirstOrDefaultAsync();

            //Không có trong group thì mapToDTO bình thường 
            if (flag == null)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToDetailDTO(result, result.Contractor.User, result.Builder.User),
                };
            }
            //MapToDTO có group 
            else
            {
                var groups = await _context.GroupMembers
                    .Include(x => x.Type)
                    .Where(x => x.GroupId == flag.Id).ToListAsync();
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToDetailGroupDTO(result, result.Contractor.User, result.Builder.User, groups),
                };
            }
            return response;
        }

        private List<CommitmentDTO> MapListDTO(List<PostCommitment> list)
        {
            List<CommitmentDTO> result = new();

            foreach (var item in list)
            {


                CommitmentDTO dto = new()
                {
                    Id = item.Id,
                    EndDate = item.EndDate,
                    OptionalTerm = item.OptionalTerm,
                    ProjectName = item.ContractorPosts.ProjectName,
                    StartDate = item.StartDate,
                    Status = item.Status,
                    Title = item.ContractorPosts.Title,
                    PostID = item.ContractorPosts.Id,
                    BuilderName = item.Builder.User.FirstName + " " + item.Builder.User.LastName,
                    BuilderPhone = item.Builder.User.PhoneNumber,
                    ConstructorName = item.Contractor.CompanyName,
                    Salary = item.Salaries,
                    BuilderTypeName = item.Builder.Type.Name
                };
                result.Add(dto);
            }
            return result;
        }


        private DetailCommitmentDTO MapToDetailDTO(PostCommitment postCommitment, User author, User builder)
        {
            CommitmentUser userA = new()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                VerifyId = author.IdNumber,
                PhoneNumber = author.PhoneNumber,
                CompanyName = author.Contractor.CompanyName

            };

            CommitmentUser userB = new()
            {
                FirstName = builder.FirstName,
                LastName = builder.LastName,
                VerifyId = builder.IdNumber,
                PhoneNumber = builder.PhoneNumber,
                TypeName = builder.Builder.Type.Name

            };


            DetailCommitmentDTO result = new()
            {
                Id = postCommitment.Id,
                Description = postCommitment.ContractorPosts.Description,
                EndDate = postCommitment.EndDate,
                IsAccepted = postCommitment.Status == Status.NOT_RESPONSE ? false : true,
                OptionalTerm = postCommitment.OptionalTerm,
                ProjectName = postCommitment.ContractorPosts.ProjectName,
                Salaries = postCommitment.Salaries,
                StartDate = postCommitment.StartDate,
                Title = postCommitment.ContractorPosts.Title,
                PostID = postCommitment.ContractorPosts.Id,
                PostSalaries = postCommitment.ContractorPosts.Salaries,
                PartyA = userA,
                PartyB = userB

            };
            return result;

        }


        private DetailCommitmentDTO MapToDetailGroupDTO(PostCommitment postCommitment, User author, User builder, List<GroupMember> groupMember)
        {

            CommitmentUser userA = new()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                VerifyId = author.IdNumber,
                PhoneNumber = author.PhoneNumber,
                CompanyName = author.Contractor.CompanyName

            };

            CommitmentUser userB = new()
            {
                FirstName = builder.FirstName,
                LastName = builder.LastName,
                VerifyId = builder.IdNumber,
                PhoneNumber = builder.PhoneNumber,
                TypeName = builder.Builder.Type.Name

            };

            var group = MapGroup(groupMember);



            DetailCommitmentDTO result = new()
            {
                Id = postCommitment.Id,
                Description = postCommitment.ContractorPosts.Description,
                EndDate = postCommitment.EndDate,
                IsAccepted = postCommitment.Status == Status.NOT_RESPONSE ? false : true,
                OptionalTerm = postCommitment.OptionalTerm,
                ProjectName = postCommitment.ContractorPosts.ProjectName,
                Salaries = postCommitment.Salaries,
                PostID = postCommitment.ContractorPosts.Id,
                StartDate = postCommitment.StartDate,
                Title = postCommitment.ContractorPosts.Title,
                PartyA = userA,
                PartyB = userB,
                Group = group

            };
            return result;

        }

        private List<CommitmentGroup> MapGroup(List<GroupMember> groupMembers)
        {
            List<CommitmentGroup> result = new();

            foreach (var item in groupMembers)
            {
                CommitmentGroup rs = new()
                {
                    DOB = item.DOB,
                    VerifyId = item.IdNumber,
                    Name = item.Name,
                    TypeID = item.TypeID,
                    TypeName = item.Type.Name
                };
                result.Add(rs);
            }
            return result;

        }

        public async Task<BaseResponse<string>> UpdateCommitment(Guid userID, int id)
        {
            BaseResponse<string> response;
            var postCommitment = await _context.PostCommitments.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (postCommitment == null)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.NOTFOUND_MESSAGE,
                    Data = null
                };
                return response;
            }

            postCommitment.Status = Status.SUCCESS;
            _context.PostCommitments.Update(postCommitment);
            await _context.SaveChangesAsync();

            //var count = _context.PostCommitments.Where(x => x.PostID == postCommitment.PostID && x.Status.Equals(Status.SUCCESS)).Count();
            //if (count == 2)
            //{
            //    var commitment = await _context.Commitments.Where(x => x.Id == commitmenntID).FirstOrDefaultAsync();
            //    commitment.Status = Status.SUCCESS;
            //    _context.Commitments.Update(commitment);
            //    await _context.SaveChangesAsync();
            //}

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE
            };
            return response;
        }

        public async Task<BaseResponse<string>> CreateCommitment(CreateCommimentRequest request, Guid ContractorID)
        {
            BaseResponse<string> response;
            PostCommitment builder;
            PostCommitment commitment;

            var ctor = await _context.Users.Include(x => x.Contractor).Where(x => x.Id.Equals(ContractorID)).FirstOrDefaultAsync();

            var post = await _context.ContractorPosts.Where(x => x.Id == request.PostContractorID).FirstOrDefaultAsync();
            if (post != null)
            {
                var group = await _context.Groups.Where(x => x.BuilderID == request.BuilderID && x.PostID == request.PostContractorID).FirstOrDefaultAsync();
                var builderID = await _context.Users.Where(x => x.BuilderId == request.BuilderID).Select(x => x.Id).FirstOrDefaultAsync();

                if (group != null)
                {
                    commitment = new()
                    {
                        PostID = request.PostContractorID,
                        BuilderID = request.BuilderID,
                        ContractorID = ctor.ContractorId.Value,
                        OptionalTerm = request.OptionalTerm,
                        Salaries = request.Salaries,
                        StartDate = post.StarDate,
                        EndDate = post.EndDate,
                        Status = Status.NOT_RESPONSE,
                        GroupID = group.Id,

                    };
                }
                else
                {
                    commitment = new()
                    {
                        PostID = request.PostContractorID,
                        BuilderID = request.BuilderID,
                        ContractorID = ctor.ContractorId.Value,
                        OptionalTerm = request.OptionalTerm,
                        Salaries = request.Salaries,
                        StartDate = post.StarDate,
                        EndDate = post.EndDate,
                        Status = Status.NOT_RESPONSE,
                    };
                }



                await _context.PostCommitments.AddAsync(commitment);
                var rs = await _context.SaveChangesAsync();


                if (rs > 0)
                {
                    if (commitment.GroupID != null)
                    {
                        var groupCount = await _context.GroupMembers.CountAsync(x=>x.GroupId== commitment.GroupID);
                        
                        var contractorPost = await _context.ContractorPosts.Where(x=>x.Id==commitment.PostID).FirstOrDefaultAsync();

                        var count = contractorPost.PeopeRemained - groupCount;

                        contractorPost.PeopeRemained = count;


                        _context.ContractorPosts.Update(contractorPost);
                       await _context.SaveChangesAsync();
                    }
                    else
                    {
                        var contractorPost = await _context.ContractorPosts.Where(x => x.Id == commitment.PostID).FirstOrDefaultAsync();

                        var count = contractorPost.PeopeRemained - 1;

                        contractorPost.PeopeRemained = count;


                        _context.ContractorPosts.Update(contractorPost);
                        await _context.SaveChangesAsync();
                    }


                    response = new()
                    {
                        Code = BaseCode.SUCCESS,
                        Message = BaseCode.SUCCESS_MESSAGE,
                        Data = builderID.ToString(),
                        NavigateId= commitment.Id
                    };
                }
                else
                {
                    response = new()
                    {
                        Code = BaseCode.ERROR,
                        Message = BaseCode.ERROR_MESSAGE,
                        Data = null
                    };
                }
                return response;
            }
            else
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.NOTFOUND_MESSAGE + "POST"
                };
            }

            return response;


        }

        public async Task<BaseResponse<DetailCommitmentDTO>> GetDetailForCreate(int postID, int builderId, Guid userID)
        {
            BaseResponse<DetailCommitmentDTO> response;
            List<DetailCommitmentDTO> ls = new();

            var post = await _context.ContractorPosts.Where(x => x.Id == postID).FirstOrDefaultAsync();
            if (post == null)
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.NOTFOUND_MESSAGE + "POST",
                };
                return response;
            }


            var builder = await _context.Users
                                .Include(x => x.Builder)
                                    .ThenInclude(x => x.Type)
                                .Where(x => x.BuilderId == builderId)
                                .FirstOrDefaultAsync();
            if (builder == null)
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.NOTFOUND_MESSAGE + "BUILDER",
                };
                return response;
            }

            var contractor = await _context.Users.Include(x => x.Contractor).Where(x => x.Id.Equals(userID)).FirstOrDefaultAsync();
            if (contractor == null)
            {
                response = new()
                {
                    Code = BaseCode.ERROR,
                    Message = BaseCode.NOTFOUND_MESSAGE + "CONTRACTOR",
                };
                return response;
            }





            var flag = await _context.Groups.Where(x => x.BuilderID == builder.Builder.Id && x.PostID == post.Id).FirstOrDefaultAsync();

            if (flag == null)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToLoadDTO(contractor, builder, post),
                };
            }
            else
            {
                var groups = await _context.GroupMembers
                    .Include(x => x.Type)
                    .Where(x => x.GroupId == flag.Id).ToListAsync();
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToLoadGroupDTO(contractor, builder, post, groups),
                };
            }
            return response;
        }

        private DetailCommitmentDTO MapToLoadDTO(User author, User builder, ContractorPost post)
        {
            CommitmentUser userA = new()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                VerifyId = author.IdNumber,
                PhoneNumber = author.PhoneNumber,
                CompanyName = author.Contractor.CompanyName

            };

            CommitmentUser userB = new()
            {
                FirstName = builder.FirstName,
                LastName = builder.LastName,
                VerifyId = builder.IdNumber,
                PhoneNumber = builder.PhoneNumber,
                TypeName = builder.Builder.Type.Name

            };


            DetailCommitmentDTO result = new()
            {
                Id = null,
                Description = post.Description,
                ProjectName = post.ProjectName,
                Salaries = post.Salaries,
                Title = post.Title,
                PostID = post.Id,
                PostSalaries = post.Salaries,
                PartyA = userA,
                PartyB = userB,
                StartDate = post.StarDate,
                EndDate = post.EndDate

            };
            return result;

        }

        private DetailCommitmentDTO MapToLoadGroupDTO(User author, User builder, ContractorPost post, List<GroupMember> groupMember)
        {
            CommitmentUser userA = new()
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                VerifyId = author.IdNumber,
                PhoneNumber = author.PhoneNumber,
                CompanyName = author.Contractor.CompanyName


            };

            CommitmentUser userB = new()
            {
                FirstName = builder.FirstName,
                LastName = builder.LastName,
                VerifyId = builder.IdNumber,
                PhoneNumber = builder.PhoneNumber,
                TypeName = builder.Builder.Type.Name

            };
            var group = MapGroup(groupMember);


            DetailCommitmentDTO result = new()
            {
                Id = null,
                Description = post.Description,
                ProjectName = post.ProjectName,
                Salaries = post.Salaries,
                Title = post.Title,
                PostID = post.Id,
                PostSalaries = post.Salaries,
                PartyA = userA,
                PartyB = userB,
                Group = group,
                StartDate = post.StarDate,
                EndDate = post.EndDate,


            };
            return result;

        }
    }
}
