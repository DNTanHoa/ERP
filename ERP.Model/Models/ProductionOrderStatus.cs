using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Model.Models
{
    public class ProductionOrderStatus : BaseModel
    {
        [Display(Name = "Tên Trạng Thái")]
        public string name { get; set; }

        [Display(Name = "Tên Trạng Thái")]
        [StringLength(3)]
        public string code { get; set; }

        [Display(Name = "Tên Trạng Thái")]
        public string note { get; set; }

        [InverseProperty("status")]
        public ICollection<ProductionOrder> productionOrders { get; set; }
    }
}
