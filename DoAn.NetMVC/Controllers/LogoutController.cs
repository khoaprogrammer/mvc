using DoAn.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.NetMVC.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {
            Session["login"] = null;
            Session["username"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}