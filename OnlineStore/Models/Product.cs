using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public int PermanentSubscription { get; set; }
        public int MonthlyPaySubscription { get; set; }

        public int SubscriptionPeriod { get; set; } //(month / quarter / year)
    }
}
