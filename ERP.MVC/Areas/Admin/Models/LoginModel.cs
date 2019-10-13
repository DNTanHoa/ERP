using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MVC.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Tên Đăng Nhập Không Được Để Trống")]
        public string username { get; set; }

        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string password { get; set; }

        public bool rememberMe { get; set; }
    }
}
