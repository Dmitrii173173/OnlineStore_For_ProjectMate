using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Manager : Person
    {
        public virtual ICollection<Client> Clients { get; set; }
    }
}
