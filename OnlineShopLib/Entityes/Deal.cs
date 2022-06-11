using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Deal : Entity
    {
        public decimal TotalPrice { get; set; }
        public virtual ClientType ClientType { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }
        public virtual Product Product { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Client Client { get; set; }
    }
}
