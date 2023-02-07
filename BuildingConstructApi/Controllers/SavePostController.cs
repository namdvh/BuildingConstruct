using Application.System.SavePost;
using Emgu.CV;
using Emgu.CV.Structure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Drawing;
using System.Reflection.PortableExecutable;
using ViewModels.Response;
using ViewModels.SavePost;

namespace BuildingConstructApi.Controllers
{
    [Route("api/savepost")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class SavePostController : ControllerBase
    {
        private readonly ISaveService _saveService;

        public SavePostController(ISaveService saveService)
        {
            _saveService = saveService;
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
