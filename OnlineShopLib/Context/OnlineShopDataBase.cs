using Microsoft.EntityFrameworkCore;
using OnlineShopLib.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Context
{
    public class OnlineShopDataBase :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<KeyClient> KeyClients { get; set; }
        public DbSet<NormalClient> NormalClients { get; set; }

        public DbSet<ClientStatus> ClientStatuses { get; set; }
        public OnlineShopDataBase(DbContextOptions<OnlineShopDataBase> options) :base(options)
        {

        }
    }
}
