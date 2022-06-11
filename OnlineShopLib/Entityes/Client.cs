using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Client : Person
    {
        public DateTime SubscriptionPeriod { get; set; } //(month / quarter / year)
        public virtual ICollection<Manager> Managers { get; set; }

    }
}
