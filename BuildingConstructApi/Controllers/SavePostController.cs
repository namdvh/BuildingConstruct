using Application.System.Notifies;
using Application.System.SavePost;
using BuildingConstructApi.Hubs;
using Data.DataContext;
using Data.Entities;
using Data.Enum;
using Emgu.CV;
using Emgu.CV.Structure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System.Drawing;
using System.Reflection.PortableExecutable;
using ViewModels.Notificate;
using ViewModels.Response;
using ViewModels.SavePost;

namespace BuildingConstructApi.Controllers
{
    [Route("api/savepost")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class SavePostController : ControllerBase
    {
        private readonly IHubContext<NotificationUserHub> _notificationUserHubContext;
        private readonly IUserConnectionManager _userConnectionManager;
        private readonly ISaveService _saveService;
        private readonly BuildingConstructDbContext _context;

        public SavePostController(ISaveService saveService, IUserConnectionManager userConnectionManager, IHubContext<NotificationUserHub> notificationUserHubContext, BuildingConstructDbContext context)
        {
            _saveService = saveService;
            _userConnectionManager = userConnectionManager;
            _notificationUserHubContext = notificationUserHubContext;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeAndSkill()
        {
            var rs = await _saveService.GetSavePostByUsID();
            return Ok(rs);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSavePost([FromBody] SavePostRequest request)
        {
            var rs = await _saveService.SavePost(request);
            var connections = _userConnectionManager.GetUserConnections(rs.Data);
            if (connections != null && connections.Count > 0)
            {
                foreach (var connectionId in connections)
                {
                    NotificationModels noti = new();
                    noti.NotificationType = 0;
                    noti.Message = NotificationMessage.SAVENOTI;
                    noti.CreateBy = Guid.Parse(rs.Data);
                    var author = await _context.Users.FindAsync(noti.CreateBy);
                    noti.Author = new();
                    noti.Author.FirstName = author.FirstName;
                    noti.Author.LastName = author.LastName;
                    noti.Author.Avatar = author.Avatar;
                    noti.LastModifiedAt=DateTime.Now;
                    await _notificationUserHubContext.Clients.Client(connectionId).SendAsync("sendToUser", noti.Message,noti.LastModifiedAt,noti.Author);
                    await _userConnectionManager.SaveNotification(noti);
                }
            }     
            return Ok(rs);
        }
        [HttpPut]
        public async Task<IActionResult> DeleteSave([FromBody] DeleteSaveRequest request)
        {
            BaseResponse<string> response = new();
            var rs = await _saveService.DeleteSave(request);
            if (rs)
            {
                response.Code = "200";
                response.Message = "Delete repost succesfully";
            }
            else
            {
                response.Code = "202";
                response.Message = "Delete repost unsuccesfully";
            }
            return Ok(response);
        }

        [HttpPost("test")]
        public async Task<IActionResult> Test(IFormFile image)
        {
            Mat front;
            Mat face;

            using (var memoryStream = new MemoryStream())
            {
                await image.CopyToAsync(memoryStream);
                using (var img = Image.FromStream(memoryStream))
                {
                    front = GetMatFromSDImage(img);
                    return Ok(_saveService.DetectFace(front));

                }
            }

            //using (var memoryStream = new MemoryStream())
            //{
            //    await image[1].CopyToAsync(memoryStream);
            //    using (var img = Image.FromStream(memoryStream))
            //    {
            //        face = GetMatFromSDImage(img);

            //    }
            //}


        }


        private Mat GetMatFromSDImage(System.Drawing.Image image)
        {
            int stride = 0;
            Bitmap bmp = new Bitmap(image);

            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            System.Drawing.Imaging.PixelFormat pf = bmp.PixelFormat;
            if (pf == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            {
                stride = bmp.Width * 4;
            }
            else
            {
                stride = bmp.Width * 3;
            }

            Image<Bgra, byte> cvImage = new Image<Bgra, byte>(bmp.Width, bmp.Height, stride, (IntPtr)bmpData.Scan0);

            bmp.UnlockBits(bmpData);

            return cvImage.Mat;
        }
    }
}
