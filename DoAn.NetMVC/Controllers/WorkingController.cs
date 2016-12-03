using DoAn.NetMVC.Models;
using FineUploader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class WorkingController : Controller
    {
        private void FuncXoaHinh(int maHinh)
        {
            IMDataContext context = new IMDataContext();
            KhoHinh delete = context.KhoHinhs.First(x => x.MaHinh == maHinh);
            var dir = HttpContext.Server.MapPath("~/Contents/Imgs");
            string path;
            foreach (var hinh in delete.DanhSachHinhTrongAlbums)
            {
                context.DanhSachHinhTrongAlbums.DeleteOnSubmit(hinh);
            }
            path = Path.Combine(dir, string.Format("{0}.{1}", delete.MaHinh, delete.Duoi));
            System.IO.File.Delete(path);
            context.KhoHinhs.DeleteOnSubmit(delete);
            context.SubmitChanges();
        }

        public void FuncXoaHinhAlbum(int maHinh, int maAlbum)
        {
            IMDataContext context = new IMDataContext();
            DanhSachHinhTrongAlbum delete = context.DanhSachHinhTrongAlbums.First(x => x.MaAlbum == maAlbum && x.MaHinh == maHinh);
            context.DanhSachHinhTrongAlbums.DeleteOnSubmit(delete);
            context.SubmitChanges();
        }

        public ActionResult XoaHinh(string maHinh)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            this.FuncXoaHinh(int.Parse(maHinh));
            return RedirectToAction("Index", "Home");
        }

        public ActionResult XoaNhieuHinh(string[] dsMaHinh)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            foreach (string ma in dsMaHinh)
            {
                this.FuncXoaHinh(int.Parse(ma));
            }
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(new { thanhcong = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SuaHinh(string maHinh, int page)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext();
            KhoHinh model = context.KhoHinhs.First(x => x.MaHinh == int.Parse(maHinh));
            ViewBag.CurrentPage = page;
            List<SelectListItem> items = context.Albums.Select(x => new SelectListItem
            {
                Text = x.TenAlbum,
                Value = x.MaAlbum.ToString()
            }).ToList();
            ViewBag.DSAlbum = items;
            return View(model);
        }

        [HttpPost]
        public ActionResult SuaHinh(KhoHinh model, int page)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext();
            KhoHinh update = context.KhoHinhs.First(x => x.MaHinh == model.MaHinh);
            update.TenHinh = model.TenHinh;
            update.MoTa = model.MoTa;
            context.SubmitChanges();
            return RedirectToAction("Index", "Home", new { page = page });
        }
        

        public ActionResult XoaHinhKhoiAlbum(string maAlbum, int maHinh)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            this.FuncXoaHinhAlbum(maHinh, int.Parse(maAlbum));
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(new { thanhcong = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ThemHinhVaoAlbum(string maAlbum, int maHinh)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext();
            if (context.DanhSachHinhTrongAlbums.Any(x => x.MaHinh == maHinh && x.MaAlbum == int.Parse(maAlbum)))
            {
                return Json(new { thanhcong = false }, JsonRequestBehavior.AllowGet);
            }
            context.DanhSachHinhTrongAlbums.InsertOnSubmit(new DanhSachHinhTrongAlbum
            {
                MaAlbum = int.Parse(maAlbum),
                MaHinh = maHinh
            });
            context.SubmitChanges();
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(new { thanhcong = true }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TimKiem(string text)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext();
            string username = (string)Session["username"];
            string input = text;
            TaiKhoan user = Global.GetUser(username);
            ViewBag.TenTK = user.TenTaiKhoan == null ? user.MaNguoiDung : user.TenTaiKhoan;
            ViewBag.Page = 1;
            var dsHinh = user.KhoHinhs.Where(x => x.TenHinh.ToUpper().Contains(text.ToUpper()) || x.MoTa.ToUpper().Contains(text.ToUpper()) || x.DateUpload.Value.ToString("d/M/yyyy") == text || x.DateUpload.Value.ToString("dd/MM/yyyy") == text).ToList();
            return View(dsHinh);
        }

        public ActionResult XoaAlbum(int maAlbum)
        {
            IMDataContext context = new IMDataContext(Global.ConnectionString);
            Album delete = context.Albums.First(x => x.MaAlbum == maAlbum);
            foreach (DanhSachHinhTrongAlbum hinh in delete.DanhSachHinhTrongAlbums)
            {
                this.FuncXoaHinhAlbum(hinh.MaHinh, delete.MaAlbum);
            }
            context.Albums.DeleteOnSubmit(delete);
            context.SubmitChanges();
            Response.StatusCode = (int)HttpStatusCode.OK;
            return Json(new { thanhcong = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ThayAvatar(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                IMDataContext context = new IMDataContext(Global.ConnectionString);
                var dir = HttpContext.Server.MapPath("~/Contents/Imgs/avatars");
                TaiKhoan user = context.TaiKhoans.First(x => x.MaNguoiDung == (string)Session["username"]);

                var filePath = Path.Combine(dir, string.Format("{0}.jpg", user.MaNguoiDung));
                file.SaveAs(filePath);
                user.pathAnhDaiDien = string.Format("{0}.jpg", user.MaNguoiDung);
                context.SubmitChanges();
            }
            return RedirectToAction("Index", "Account");
        }
    }
}