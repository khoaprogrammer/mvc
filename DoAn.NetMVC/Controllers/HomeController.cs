using DoAn.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page)
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            IMDataContext context = new IMDataContext(Global.ConnectionString);
            TaiKhoan tk = Global.GetUser((string)Session["username"]);
            ViewBag.Page = page;
            ViewBag.AnhDaiDien = tk.pathAnhDaiDien;
            ViewBag.MaNguoiDung = tk.MaNguoiDung;
            ViewBag.TenTaiKhoan = tk.TenTaiKhoan;
            ViewBag.PageType = "HOME";
            var ds = context.KhoHinhs.Where(x => x.MaNguoiDung.Equals(tk.MaNguoiDung)).OrderByDescending(x => x.MaHinh).ToList();
            return View(ds);
        }
    }
}