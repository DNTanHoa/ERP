using ERP.Model.Context;
using ERP.Model.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Model.Service
{
    public class UserService
    {
        public ERPContext _context;

        public UserService(ERPContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Authentication user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if(_context.users.ToList().Count < 1)
            {
                Users admin = new Users
                {
                    username = "admin",
                    password = "admin",
                    isActive = true,
                };
                _context.users.Add(admin);
                _context.SaveChanges();
            }

            Users user = _context.users.FirstOrDefault<Users>(item => item.username.Equals(username) &&
                                                                      item.password.Equals(password) &&
                                                                      item.isActive);
            return user != null ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Users GetUserByUsername(string username)
        {
            return _context.users.SingleOrDefault(user => user.username.Equals(username));
        }
    }
}
