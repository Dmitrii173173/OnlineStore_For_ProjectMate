using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class ClientStatus : Entity
    {
        public virtual KeyClient KeyClient { get; set; }
        public virtual NormalClient NormalClient { get; set; }
    }
}
