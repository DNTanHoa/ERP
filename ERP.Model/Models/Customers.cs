using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP.Model.Models
{
    public class Customers : BaseModel
    {
        [Display(Name = "Tên Khách Hàng")]
        public string name { get; set; }

        [Display(Name = "Mã Khách Hàng")]
        public string code { get; set; }

        [Display(Name = "Người Đại Diện")]
        public string representative { get; set; }

        [Display(Name = "Số Điện Thoại Người Đại Diện")]
        public string representativePhone { get; set; }

        [Display(Name = "Email Người Đại Diện")]
        public string representativeEmail { get; set; }

        [Display(Name = "Điện Thoại Khách Hàng")]
        public string phone { get; set; }

        [Display(Name = "Địa Chỉ")]
        public string address { get; set; }

        [Display(Name = "Mã Số Thuế")]
        public string taxCode { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "TGhi Chú")]
        public string note { get; set; }

        [Display(Name = "Lệnh Sản Xuất")]
        public virtual ICollection<ProductionOrder> productionOrders { get; set; }
    }
}