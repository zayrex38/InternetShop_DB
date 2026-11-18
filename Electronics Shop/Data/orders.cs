using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Electronics_Shop.Data
{
    public class orders
    {
        [Key]
        public int id { get; set; }

        [ForeignKey(nameof(Customer))]
        public int customer_id { get; set; }
        public Customers Customer { get; set; }

        [ForeignKey(nameof(Courier))]
        public int courier_id { get; set; }
        public couriers Courier { get; set; }

        public string delivery_adrress { get; set; }

        public string desired_date { get; set; }

        public string order_date { get; set; }

        public string status { get; set; }

    }
}
