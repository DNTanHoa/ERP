using ERP.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.MVC.Commons
{
    [Serializable]
    public class UserSession
    {
        public Guid userOid { get; set; }

        public string userName { get; set; }

        public List<Roles> roles { get; set; }
    }
}
