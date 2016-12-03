using DoAn.NetMVC.Models;
using FineUploader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        [HttpGet]
        public ActionResult Index()
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        [HttpPost]
        public FineUploaderResult UploadFile(FineUpload upload, string extraParam1, int? extraParam2)
        {
            // asp.net mvc will set extraParam1 and extraParam2 from the params object passed by Fine-Uploader
            IMDataContext context = new IMDataContext(Global.ConnectionString);

            var dir = HttpContext.Server.MapPath("~/Contents/Imgs");
            string fileName = upload.Filename.Split('.')[0];
            string extension = upload.Filename.Split('.')[1];
            int maxMaHinh = 0;
            if (context.KhoHinhs.Any())
            {
                maxMaHinh = context.KhoHinhs.Max(x => x.MaHinh);
            }


            var filePath = Path.Combine(dir, string.Format("{0}.{1}", maxMaHinh + 1, extension));
            try
            {
                upload.SaveAs(filePath, true);
            }
            catch (Exception ex)
            {
                return new FineUploaderResult(false, error: ex.Message);
            }

            TaiKhoan user = Global.GetUser((string)Session["username"]);

            ImageInfo img = new ImageInfo(filePath);
            context.KhoHinhs.InsertOnSubmit(new KhoHinh
            {
                MaHinh = maxMaHinh + 1,
                Duoi = "." + extension,
                MaNguoiDung = user.MaNguoiDung,
                TenHinh = fileName,
                MoTa = string.Empty,
                DateUpload = DateTime.Today,
                Height = img.Heigth(),
                Width = img.Width(),
                Size = img.Size()
            });
            context.SubmitChanges();

            // the anonymous object in the result below will be convert to json and set back to the browser
            return new FineUploaderResult(true);
        }
    }
}