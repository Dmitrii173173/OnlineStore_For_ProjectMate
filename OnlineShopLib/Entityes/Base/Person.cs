using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes.Base
{
    public abstract class Person : NamedEntityes
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
