using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AutoValidateAntiforgeryToken]
    [Authorize(AuthenticationSchemes = "DemoSecurityScheme")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("/Areas/Admin/Views/Home.cshtml");
        }
    }
}