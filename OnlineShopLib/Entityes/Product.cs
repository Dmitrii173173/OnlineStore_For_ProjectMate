using OnlineShopLib.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineShopLib.Entityes
{
    public class Product : NamedEntityes
    {
        /*Есть Товар (Product) с атрибутами: Название,
            Цена, Тип (подписка или постоянная лицензия), Срок подписки (месяц / квартал / год)*/


        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public virtual LicenseType LicenseType { get; set; }

    }
}
