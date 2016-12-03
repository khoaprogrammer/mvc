using DoAn.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            if ((string)Session["login"] != "OK")
            {
                return RedirectToAction("Index", "Login");
            }
            TaiKhoan user = Global.GetUser((string)Session["username"]);
            ViewBag.AnhDaiDien = user.pathAnhDaiDien;
            return View(user);
        }
    }
}