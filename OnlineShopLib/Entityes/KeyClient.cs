using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class KeyClient : Client
    {
        public virtual ICollection<Product> Products { get; set; } //ItemsPurchased

        public virtual Manager Manager { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }

    }
}
