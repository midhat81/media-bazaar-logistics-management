using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<int, int> RequiredPersonnel { get; set; }
        public string PointOfContact { get; set; }

        public DepartmentDTO(int id, string name, string description, string pointOfContact)
        {
            Id = id;
            Name = name;
            Description = description;
            PointOfContact = pointOfContact;
            RequiredPersonnel = new Dictionary<int, int>();
        }
    }
}
