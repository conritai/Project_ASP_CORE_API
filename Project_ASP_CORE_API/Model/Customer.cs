using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Customer
    {
        public string customer_id { get; set; }
        public string full_name { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public DateTime submit_on { get; set; }
        public string domain_name { get; set; }

    }
}
