using ERP.Model.Context;
using ERP.Model.Service;
using ERP.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            UserService service = new UserService(context);
            bool loginResult = service.Login(model.username, model.password);

            if (ModelState.IsValid)
            {
                if(loginResult)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "Cookie authentication demo"),
                        new Claim(ClaimTypes.Email, model.username)
                    };

                    ClaimsIdentity identity = new ClaimsIdentity(claims, "cookie");

                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("DemoSecurityScheme", principal, new AuthenticationProperties { });

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.Clear();
                    ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Tồn Tại");
                }
            }
            else
            {
                ModelState.Clear();
                ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Hợp Lệ");

            }
            return View("/Views/Login/Login.cshtml");
        }
    }
}