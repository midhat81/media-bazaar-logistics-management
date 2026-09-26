using DataAccessLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RoleManager
    {
        private RoleDAL _roleDAL;

        public RoleManager()
        {
            _roleDAL = new RoleDAL();
        }

        public RoleDTO GetRoleById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be greater than 0");
            }
            return _roleDAL.GetRoleById(id);
        }

        public void AddRole(RoleDTO role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            _roleDAL.CreateRole(role);
        }

        public void UpdateRole(RoleDTO role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            _roleDAL.UpdateRole(role);
        }

        public void DeleteRole(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be greater than 0");
            }
            _roleDAL.DeleteRole(id);
        }

        public List<RoleDTO> GetAllRoles()
        {
            return _roleDAL.GetAllRoles();
        }

        public Role ConvertToEntity(RoleDTO dto)
        {
            return new Role(dto.Id, dto.Role);
        }

        public RoleDTO ConvertToDTO(Role role)
        {
            return new RoleDTO(role.id, role.role);
        }
    }
}
