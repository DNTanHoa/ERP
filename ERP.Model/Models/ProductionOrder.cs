using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Model.Models
{
    public class ProductionOrder : BaseModel
    {
        [Display(Name = "Mã Lệnh Sản Xuất")]
        public string code { get; set; }

        [Display(Name = "Tên Lệnh Sản Xuất")]
        public string name { get; set; }
        
        [Display(Name = "Ngày Yêu Cầu Hoàn Thành")]
        public DateTime? deadline { get; set; }

        [Display(Name = "Ngày Bắt Đầu")]
        public DateTime? startDate { get; set; }

        [Display(Name = "Ngày Kết Thúc")]
        public DateTime? finishDate { get; set; }

        public Guid supervisorOid { get; set; }
        [Display(Name = "Người Giám Sát")]
        [ForeignKey("supervisorOid")]
        public virtual Employees supervisor { get; set; }

        //TODO: implement to get list employee

        [Display(Name = "Khách Hàng")]
        public Customers customer { get; set; }

        [StringLength(5)]
        [Display(Name = "Phiên Bản")]
        public string version { get; set; }

        public Guid productionStatusOid { get; set; }
        [Display(Name = "Tình Trạng")]
        [ForeignKey("productionStatusOid")]
        public ProductionOrderStatus status { get; set; }

        [Display(Name = "Trễ Hạn")]
        public bool isLate { get; set; }

        [Display(Name = "Ghi Chú" )]
        public string note { get; set; }

    }

}
