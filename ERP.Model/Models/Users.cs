using ERP.Model.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Model.Models
{
    public class Users : BaseModel
    {
        public string username { get; set; }

        public string storedPassword { get; set; }

        [NotMapped]
        public string password
        {
            get => PasswordHelper.Decrypt(this.storedPassword, this.Oid.ToString());
            set => this.storedPassword = PasswordHelper.Encrypt(value.ToString(), this.Oid.ToString());
        }

        public bool isActive { get; set; }

        public IList<Roles> roles { get; }
    }
}
