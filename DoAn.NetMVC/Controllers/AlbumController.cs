using DoAn.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class AlbumController : Controller
    {
        public ActionResult Index()
        {
            IMDataContext context = new IMDataContext(Global.ConnectionString);
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            TaiKhoan user = Global.GetUser((string)Session["username"]);
            return View(context.Albums.Where(x => x.MaNguoiDung.Equals(user.MaNguoiDung)).ToList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new Album());
        }

        [HttpPost]
        public ActionResult Add(Album album)
        {
            TaiKhoan user = Global.GetUser((string)Session["username"]);
            album.MaNguoiDung = user.MaNguoiDung;
            IMDataContext context = new IMDataContext();
            if (context.Albums.Count() == 0)
            {
                album.MaAlbum = 0;
            }
            else
            {
                album.MaAlbum = (int)context.Albums.Max(x => x.MaAlbum) + 1;
            }
            context.Albums.InsertOnSubmit(album);
            context.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int maAlbum, int page = 1)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext();
            TaiKhoan user = Global.GetUser((string)Session["username"]);
            var album = context.Albums.First(x => x.MaAlbum == maAlbum);
            var dsHinh = album.DanhSachHinhTrongAlbums.Select(x => x.KhoHinh).ToList();
            ViewBag.Page = page;
            ViewBag.AnhDaiDien = user.pathAnhDaiDien;
            ViewBag.AlbumCode = album.MaAlbum;
            ViewBag.AlbumName = album.TenAlbum;
            return View(dsHinh);
        }
    }
}