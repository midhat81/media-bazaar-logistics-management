using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Role { get; set; }

        public RoleDTO(int id, string role)
        {
            Id = id;
            Role = role;
        }
    }
}
