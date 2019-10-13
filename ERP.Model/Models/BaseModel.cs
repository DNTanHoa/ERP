using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ERP.Model.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.Oid = Guid.NewGuid();
            this.createDate = DateTime.Now;
            this.updateDate = DateTime.Now;
        }

        [Key]
        public Guid  Oid { get; set; }

        [Timestamp]
        public int? OptimisticLockField { get; set; }

        public DateTime createDate { get; set; }

        public DateTime updateDate { get; set; }
    }
}
