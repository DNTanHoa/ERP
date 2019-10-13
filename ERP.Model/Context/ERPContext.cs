using ERP.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Model.Context
{
    public class ERPContext : DbContext
    {
        public ERPContext (DbContextOptions<ERPContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<BaseModel>();
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Roles> role { get; set; }
    }
}
