using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Electronics_Shop.Data
{
    public class Customers
    {
        [Key]
        public int id { get; set; }

        public string last_name { get; set; }

        public string first_name { get; set; }

        public string middle_name { get; set; }

        public string birth_date { get; set; }

        public string address { get; set; }

        public string email { get; set; }

        public string login { get; set; }

        public string password { get; set; }
    }
}
