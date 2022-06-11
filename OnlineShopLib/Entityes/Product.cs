using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Product : NamedEntityes
    {
        [Column(TypeName = "decimal(18.2)")]
        public decimal Price { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
