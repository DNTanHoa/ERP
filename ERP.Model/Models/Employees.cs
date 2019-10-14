using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Model.Models
{
    public class Employees : BaseModel
    {
        public string name { get; set; }

        public string code { get; set; }

        [InverseProperty("supervisor")]
        public virtual ICollection<ProductionOrder> productionOrderSupervisor { get; set; }
    }
}
