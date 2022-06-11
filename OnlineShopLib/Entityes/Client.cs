using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Client : Person
    {
        public virtual ICollection<ClientStatus> ClientStatus { get; set; }

        public virtual ICollection<ClientType> ClientType { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
