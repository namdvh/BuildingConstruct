using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Emgu.CV;
using Emgu.CV.Features2D;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Dynamic.Core;
using ViewModels.Identification;
using ViewModels.Pagination;
using ViewModels.Response;


namespace Application.System.Identification
{
    public class IdentificationService : IIdentificationService
    {
        private readonly BuildingConstructDbContext _context;
        private readonly UserManager<User> _userService;


        public IdentificationService(BuildingConstructDbContext context, UserManager<User> userService)
        {
            _context = context;
            _userService = userService;
        }


        public async Task<BaseResponse<string>> Create(Guid userID, CreateIndetificationRequest requests)
        {
            BaseResponse<string> response;

            Verify verify = new()
            {
                BackID = requests.BackID,
                BusinessLicense = requests.BusinessLicense,
                CreateBy = userID,
                UserID = userID,
                FaceImage = requests.FaceImage,
                FrontID = requests.FrontID,
                IdentificateType = requests.IdentificateType,
                LastModifiedAt = DateTime.Now,
                PreCodition = requests.PreCodition,
                Status = Status.PENDING,
            };

            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id.Equals(userID));

            if (user != null)
            {
                user.Status = Status.LEVEL_4;
                _context.Users.Update(user);
            }

            await _context.Verifies.AddAsync(verify);
            await _context.SaveChangesAsync();

            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.SUCCESS_MESSAGE
            };

            return response;

        }

        public BaseResponse<string> DetectFace(Mat image)
        {
            BaseResponse<string> response;

            var test = Path.GetDirectoryName("haarcascade_frontalface_default.xml");

            string path = Path.GetFullPath("haarcascade_frontalface_default.xml");
            var f = path.Replace("\\BuildingConstructApi\\haarcascade_frontalface_default.xml", "\\BuildingConstructApplication\\Library\\haarcascade_frontalface_default.xml");
            // Load the face detection model
            using (var faceDetector = new CascadeClassifier(f))
            {
                // Detect faces in the image
                Rectangle[] faces = faceDetector.DetectMultiScale(
                        image,
                        scaleFactor: 1.1,
                        minNeighbors: 10,
                        minSize: new Size(20, 20)
                    );

                // If a face was detected, extract its descriptor
                if (faces.Length > 0)
                {
                    // Use the first detected face
                    Rectangle face = faces[0];

                    // Crop the face from the image
                    Mat faceImage = new Mat(image, face);

                    // Resize the face image to a standard size
                    CvInvoke.Resize(faceImage, faceImage, new Size(300, 300));

                    // Return the face descriptor
                    //return faceImage.ToImage<Gray, byte>().Mat;
                    response = new()
                    {
                        Code = BaseCode.SUCCESS,
                        Message = "Detected"
                    };
                    return response;
                }
            }

            // Return null if no face was detected
            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = "Not Detected"
            };
            return response;
        }

        public async Task<BasePagination<List<IdentificationDTO>>> GetAll(PaginationFilter filter)
        {
            BasePagination<List<IdentificationDTO>> response;
            var orderBy = filter._orderBy.ToString();
            int totalRecords = 0;

            List<Verify>? data;
            var query = _context.Verifies;

            if (string.IsNullOrEmpty(filter._sortBy))
            {
                filter._sortBy = "Id";
            }
            orderBy = orderBy switch
            {
                "1" => "ascending",
                "-1" => "descending",
                _ => orderBy
            };
            if (filter.FilterRequest != null && filter.FilterRequest.Status.HasValue)
            {
                data = await query
                  .Include(x => x.User)
                  .OrderBy(filter._sortBy + " " + orderBy)
                  .Skip((filter.PageNumber - 1) * filter.PageSize)
                  .Take(filter.PageSize)
                  .Where(x => x.Status == filter.FilterRequest.Status)
                  .ToListAsync();

                totalRecords = await _context.Verifies.Where(x => x.Status == filter.FilterRequest.Status).CountAsync();
            }
            else
            {
                data = await query
                  .Include(x => x.User)
                  .OrderBy(filter._sortBy + " " + orderBy)
                  .Skip((filter.PageNumber - 1) * filter.PageSize)
                  .Take(filter.PageSize)
                  .ToListAsync();
                totalRecords = await _context.Verifies.CountAsync();
            }


            if (!data.Any())
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

                totalPages = totalRecords / (double)filter.PageSize;

                var roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
                Pagination pagination = new()
                {
                    CurrentPage = filter.PageNumber,
                    PageSize = filter.PageSize,
                    TotalPages = roundedTotalPages,
                    TotalRecords = totalRecords
                };

                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = MapListDTO(data),
                    Pagination = pagination
                };
            }

            return response;

        }

        public async Task<BaseResponse<IdentificationDTO>> GetDetail(int id)
        {
            BaseResponse<IdentificationDTO> response;

            var rs = await _context.Verifies.FirstOrDefaultAsync(x => x.Id == id);
            if (rs != null)
            {
                IdentificationDTO final = new()
                {
                    BackID = rs.BackID,
                    BusinessLicense = rs.BusinessLicense,
                    UserID = rs.UserID,
                    FaceImage = rs.FaceImage,
                    FrontID = rs.FrontID,
                    IdentificateType = rs.IdentificateType,
                    LastModifiedAt = rs.LastModifiedAt,
                    PreCodition = rs.PreCodition,
                    Status = rs.Status,
                };
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = final
                };
            }
            response = new()
            {
                Code = BaseCode.SUCCESS,
                Message = BaseCode.NOTFOUND_MESSAGE,
            };

            return response;
        }

        public async Task<BaseResponse<string>> Update(int id, Status status)
        {
            BaseResponse<string> response;

            var rs = await _context.Verifies.FirstOrDefaultAsync(x => x.Id == id);
            if (rs != null)
            {
                var user = await _context.Users
                    .Include(x => x.MaterialStore)
                    .Include(x => x.Builder)
                    .Include(x => x.Contractor)
                    .FirstOrDefaultAsync(x => x.Id.Equals(rs.UserID));
                if (user != null)
                {
                    if (status == Status.DECLINED)
                    {
                        var rolename = _userService.GetRolesAsync(user).Result;

                        if (rolename.First().Equals("User"))
                        {
                            if (user.Avatar != null && user.Builder.TypeID != null && user.Builder.Place != null && user.IdNumber != null)
                            {
                                user.Status = Status.Level2;
                            }
                            else
                            {
                                user.Status = Status.SUCCESS;
                            }
                            _context.Update(user);
                        }
                        else if (rolename.First().Equals("Contractor"))
                        {
                            if (user.Avatar != null && user.Contractor.CompanyName != null && user.IdNumber != null)
                            {
                                user.Status = Status.Level2;
                            }
                            else
                            {
                                user.Status = Status.SUCCESS;
                            }
                            _context.Update(user);
                        }
                        else
                        {
                            if (user.Avatar != null && user.MaterialStore.Place != null && user.MaterialStore.TaxCode != null)
                            {
                                user.Status = Status.Level2;
                            }
                            else
                            {
                                user.Status = Status.SUCCESS;
                            }
                            _context.Update(user);
                        }

                        _context.Remove(rs);
                        await _context.SaveChangesAsync();

                    }
                    else
                    {
                        rs.Status = status;

                        rs.LastModifiedAt = DateTime.Now;
                        _context.Update(rs);
                        await _context.SaveChangesAsync();

                        if (user != null)
                        {
                            if (user.Status == Status.Level2 && status == Status.SUCCESS)
                            {
                                user.Status = Status.Level3;
                            }
                            else if (status == Status.SUCCESS)
                            {
                                user.Status = Status.Level1;
                            }





                            _context.Update(user);
                            await _context.SaveChangesAsync();
                        }
                    }

                }




                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.SUCCESS_MESSAGE,
                    Data = rs.UserID.ToString()
                };
            }
            else
            {
                response = new()
                {
                    Code = BaseCode.SUCCESS,
                    Message = BaseCode.NOTFOUND_MESSAGE,
                };

            }

            return response;
        }


        private List<IdentificationDTO> MapListDTO(List<Data.Entities.Verify> verifies)
        {

            List<IdentificationDTO> ls = new();

            foreach (var item in verifies)
            {
                IdentificationDTO tmp = new()
                {
                    Id = item.Id,
                    BackID = item.BackID,
                    BusinessLicense = item.BusinessLicense,
                    UserID = item.UserID,
                    FaceImage = item.FaceImage,
                    FrontID = item.FrontID,
                    IdentificateType = item.IdentificateType,
                    LastModifiedAt = item.LastModifiedAt,
                    PreCodition = item.PreCodition,
                    Status = item.Status,
                    Name = item.User?.FirstName + " " + item.User?.LastName
                };
                ls.Add(tmp);
            }

            return ls;

        }

    }
}
