using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Permission
    {
        [Key]
        public string permission_id { get; set; }
        public string permission_name { get; set; }
        public string description { get; set; }
    }
}
