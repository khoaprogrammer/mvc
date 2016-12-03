using DoAn.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TaiKhoan tk)
        {
            TaiKhoan taikhoan = Global.GetUser(tk.MaNguoiDung);
            ViewBag.IsRegistering = false;
            if (taikhoan == null)
            {
                ViewBag.ErrorMessage = "Tải khoản không tồn tại";
            }
            else
            {
                if (taikhoan.MatKhau.Equals(tk.MatKhau))
                {
                    Session["login"] = "OK";
                    Session["username"] = tk.MaNguoiDung;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Sai mật khẩu";
                }
            }
            return View("Index", tk);  
        }

        [HttpPost]
        public ActionResult Register(TaiKhoan tk)
        {
            IMDataContext context = new IMDataContext();
            ViewBag.IsRegistering = true;
            if (context.TaiKhoans.Any(x => x.MaNguoiDung.Equals(tk.MaNguoiDung)))
            {
                ViewBag.ErrorMessage = "Tên đăng nhập không khả dụng";
                return View("Index", tk);
            }
            else
            {
                context.TaiKhoans.InsertOnSubmit(tk);
                context.SubmitChanges();
                ViewBag.ErrorMessage = "Đăng kí thành công";
                return View("Index");
            }
        }
    }
}