using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Dictionary<RoleDTO, int> RequiredPersonnel { get; private set; }
        public string PointOfContact { get; private set; }

        public Department(int id, string name, string description, Dictionary<RoleDTO, int> requiredPersonnel, string pointOfContact)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            RequiredPersonnel = requiredPersonnel ?? throw new ArgumentNullException(nameof(requiredPersonnel));
            PointOfContact = pointOfContact ?? throw new ArgumentNullException(nameof(pointOfContact));
        }
    }
}
