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
        public DbSet<ProductionOrder> productionOrders { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<ProductionOrderStatus> productionOrdersStatus { get; set; }
        public DbSet<Customers> customers { get; set; }
    }
}
