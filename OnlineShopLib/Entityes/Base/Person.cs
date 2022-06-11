using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopLib.Entityes.Base
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
    }
}
