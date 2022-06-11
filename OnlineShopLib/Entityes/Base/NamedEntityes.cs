using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineShopLib.Entityes.Base
{
    public abstract class NamedEntityes : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
