﻿using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using ViewModels.Commitment;
using ViewModels.ContractorPost;
using ViewModels.Pagination;
using ViewModels.Response;

namespace Application.System.Commitments
{
    public class CommitmentService : ICommitmentService
    {
        private readonly BuildingConstructDbContext _context;

        public CommitmentService(BuildingConstructDbContext context)
        {
            _context = context;
        }

        public async Task<BasePagination<List<CommitmentDTO>>> GetCommitment(Guid UserID, PaginationFilter filter)
        {
            BasePagination<List<CommitmentDTO>> response;

            var orderBy = filter._orderBy.ToString();
            int totalRecord;

            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            var result = await _context.PostCommitments
                .Include(x => x.ContractorPosts)
                .Include(x => x.Commitment)
                .Where(x => x.UserID.Equals(UserID))
                .OrderBy(filter._orderBy + " " + orderBy)
                .Skip((filter.PageNumber - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .ToListAsync();

            totalRecord = await _context.PostCommitments.Where(x => x.UserID.Equals(UserID)).CountAsync();


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

        public async Task<BaseResponse<DetailCommitmentDTO>> GetDetailCommitment(int commitmenntID)
        {
            BaseResponse<DetailCommitmentDTO> response;
            List<DetailCommitmentDTO> ls = new();
            bool isInGroup = false;

            //have 2 items.
            var result = await _context.PostCommitments
                .Include(x => x.ContractorPosts)
                .Include(x => x.Commitment)
                .Where(x => x.CommitmentID == commitmenntID)
                .ToListAsync();

            var authorID = result.Where(x => x.IsAuthor == true).Select(x => x.UserID).FirstOrDefault();
            var builderID = result.Where(x => x.IsAuthor == false).Select(x => x.UserID).FirstOrDefault();

            var author = await _context.Users.Where(x => x.Id.Equals(authorID)).FirstOrDefaultAsync();
            var builder = await _context.Users.Where(x => x.Id.Equals(builderID)).FirstOrDefaultAsync();


            var flag = await _context.Groups.Where(x => x.BuilderID == builder.BuilderId && x.PostID == result.First().PostID).FirstOrDefaultAsync();

            //Không có trong group thì mapToDTO bình thường 
            if (flag == null)
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToDetailDTO(result.First(), author, builder),
                };
            }
            //MapToDTO có group 
            else
            {
                var groups = await _context.GroupMembers.Where(x => x.GroupId == flag.Id).ToListAsync();
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapToDetailGroupDTO(result.First(), author, builder, groups),
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
                    CommitmentId = item.CommitmentID,
                    EndDate = item.Commitment.EndDate,
                    OptionalTerm = item.Commitment.OptionalTerm,
                    ProjectName = item.ContractorPosts.ProjectName,
                    StartDate = item.Commitment.StartDate,
                    Status = item.Commitment.Status,
                    Title = item.ContractorPosts.Title
                };
                result.Add(dto);
            }
            return result;
        }


        private DetailCommitmentDTO MapToDetailDTO(PostCommitment postCommitment, User author, User builder)
        {
            DetailCommitmentDTO result = new()
            {
                Description = postCommitment.ContractorPosts.Description,
                EndDate = postCommitment.Commitment.EndDate,
                Status = postCommitment.Status,
                OptionalTerm = postCommitment.Commitment.OptionalTerm,
                ProjectName = postCommitment.ContractorPosts.ProjectName,
                StartDate = postCommitment.Commitment.StartDate,
                Title = postCommitment.ContractorPosts.Title,
                PartyA =
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    IDNumber = author.IdNumber
                },
                PartyB =
                {
                    FirstName = builder.FirstName,
                    LastName = builder.LastName,
                    IDNumber = builder.IdNumber
                }

            };
            return result;

        }

        private DetailCommitmentDTO MapToDetailGroupDTO(PostCommitment postCommitment, User author, User builder, List<GroupMember> groupMember)
        {
            DetailCommitmentDTO result = new()
            {
                Description = postCommitment.ContractorPosts.Description,
                EndDate = postCommitment.Commitment.EndDate,
                Status = postCommitment.Status,
                OptionalTerm = postCommitment.Commitment.OptionalTerm,
                ProjectName = postCommitment.ContractorPosts.ProjectName,
                StartDate = postCommitment.Commitment.StartDate,
                Title = postCommitment.ContractorPosts.Title,
                PartyA =
                {
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    IDNumber = author.IdNumber
                },
                PartyB =
                {
                    FirstName = builder.FirstName,
                    LastName = builder.LastName,
                    IDNumber = builder.IdNumber
                },
                Group = MapGroup(groupMember)



            };
            return result;

        }

        private List<CommitmentGroup> MapGroup(List<GroupMember> groupMembers)
        {
            List<CommitmentGroup> result = new();

            foreach (var item in result)
            {
                CommitmentGroup rs = new()
                {
                    DOB = item.DOB,
                    IdNumber = item.IdNumber,
                    Name = item.Name,
                    TypeID = item.TypeID,
                };
                result.Add(rs);
            }
            return result;

        }

        public async Task<BaseResponse<string>> UpdateCommitment(Guid userID, int commitmenntID)
        {
            BaseResponse<string> response;
            var postCommitment = await _context.PostCommitments.Where(x => x.UserID.Equals(userID) && commitmenntID == commitmenntID).FirstOrDefaultAsync();

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
            _context.PostCommitments.Add(postCommitment);
            _context.SaveChanges();

            var count = _context.PostCommitments.Where(x => x.PostID == postCommitment.PostID && x.Status.Equals(Status.SUCCESS)).Count();
            if (count == 2)
            {
                var commitment = await _context.Commitments.Where(x => x.Id == commitmenntID).FirstOrDefaultAsync();
                commitment.Status = Status.SUCCESS;
                await _context.Commitments.AddAsync(commitment);
                await _context.SaveChangesAsync();
            }

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE
            };
            return response;
        }
    }
}