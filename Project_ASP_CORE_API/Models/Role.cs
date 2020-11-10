using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_ASP_CORE_API.Model
{
    public class Role
    {
        [Key]
        public Guid Role_id { get; set; }
        public string Role_name { get; set; }
        public DateTime Create_role_at { get; set; }
        public DateTime Update_role_at { get; set; }
        public ICollection<Role_n_Permission> Role_n_Permissions { get; set; }
    }
}
