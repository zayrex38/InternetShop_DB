    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    namespace Electronics_Shop.Data
    {
        public class couriers
        {
            [Key]
            public int courier_id { get; set; }

            public string last_name { get; set; }

            public string first_name { get; set; }

            public string middle_name { get; set; }

            public string contact { get; set; }



        }
    }
