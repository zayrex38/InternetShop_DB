using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electronics_Shop.Data
{
    public class sold_products
    {
        [Key]
        public int id { get; set; }

        [ForeignKey(nameof(order))]
        public int order_id { get; set; }
        public orders order { get; set; }

        [ForeignKey(nameof(product))]
        public int product_id { get; set; }
        public products product { get; set; }
        public int quantity { get; set; }

        public decimal sold_price { get; set; }

        public string sale_data { get; set; }
    }
}
