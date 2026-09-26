using DataAccessLayer;
using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class DepartmentManager : IDepartmentManager
    {
        private DepartmentDAL _departmentDAL;
        private RoleManager _roleManager;

        public DepartmentManager()
        {
            _departmentDAL = new DepartmentDAL();
            _roleManager = new RoleManager();
        }

        public DepartmentDTO GetDepartmentById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be greater than 0");
            }
            return _departmentDAL.ReadDepartment(id);
        }

        public void AddDepartment(DepartmentDTO department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department));
            }
            department.Id = _departmentDAL.GetNextId();
            _departmentDAL.CreateDepartment(department);
        }

        public void UpdateDepartment(DepartmentDTO department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department));
            }
            _departmentDAL.UpdateDepartment(department);
        }

        public void DeleteDepartment(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("id must be greater than 0");
            }
            _departmentDAL.DeleteDepartment(id);
        }

        public List<DepartmentDTO> GetAllDepartments()
        {
            return _departmentDAL.GetAllDepartments();
        }

        public DepartmentDTO ConvertToDTO(Department department)
        {
            var requiredPersonnel = department.RequiredPersonnel.ToDictionary(kvp => (int)kvp.Key.Id, kvp => kvp.Value);
            return new DepartmentDTO(department.Id, department.Name, department.Description, department.PointOfContact)
            {
                RequiredPersonnel = requiredPersonnel
            };
        }

        public Department ConvertToEntity(DepartmentDTO dto)
        {
            var requiredPersonnel = dto.RequiredPersonnel.ToDictionary(kvp => _roleManager.GetRoleById(kvp.Key), kvp => kvp.Value);
            return new Department(dto.Id, dto.Name, dto.Description, requiredPersonnel, dto.PointOfContact);
        }
    }
}
