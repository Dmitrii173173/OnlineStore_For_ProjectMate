using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class ProductType
    {

        public string PermanentSubscription { get; set; }
        public string MonthlyPaySubscription { get; set; }

        public DateTime SubscriptionPeriod { get; set; } //(month / quarter / year)

    }
}
