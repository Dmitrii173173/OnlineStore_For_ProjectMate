using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class LicenseType :NamedEntityes
    {
        public string NameOfLicense { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal LicensePrice { get; set; }
    }
}
