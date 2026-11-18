using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Electronics_Shop.Data
{
    public class products
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string category { get; set; }

        public string manufacturer { get; set; }

        public decimal price { get; set; }
        
        public string specifications { get; set; }

        public int Test2 { get; set; }
    }
}
