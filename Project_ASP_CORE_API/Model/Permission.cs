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
        public Guid Permission_id { get; set; }
        public string Permission_name { get; set; }
        public string Description { get; set; }
        public ICollection<Role_n_Permission> Role_n_Permission { get; set; }
    }
}
