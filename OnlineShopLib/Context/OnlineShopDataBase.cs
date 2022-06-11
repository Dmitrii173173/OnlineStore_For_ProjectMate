using Microsoft.EntityFrameworkCore;
using OnlineShopLib.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Context
{
    public class OnlineShopDataBase :DbContext
    {
        public DbSet<Deal> Deals { get; set; }
        public DbSet<LicenseType> LicenseTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ClientStatus> ClientStatus { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public OnlineShopDataBase(DbContextOptions<OnlineShopDataBase> options) :base(options)
        {

        }
    }
}
