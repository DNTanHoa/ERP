using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Model.Context;
using ERP.Model.Models;
using ERP.MVC.Helpers;
using ERP.Model.Service;
using ERP.MVC.Areas.Admin.Models;
using ERP.MVC.Commons;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ERP.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly ERPContext context;

        public LoginController(ERPContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View("/Views/Login/Login.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            UserService service = new UserService(context);
            bool loginResult = service.Login(model.username, model.password);

            if (loginResult && ModelState.IsValid)
            {
                /// Get user infor mation and save to session
                var user = service.GetUserByUsername(model.username);
                var userSession = new UserSession();
                userSession.userName = user.username;
                userSession.userOid = user.Oid;
                //TODO: Add user's roles to session

                HttpContext.Session.SetObjectAsJson("UserSession", JsonConvert.SerializeObject(userSession));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Hợp Lệ");
            }
            return View("/Views/Login/Login.cshtml");
        }
    }
}