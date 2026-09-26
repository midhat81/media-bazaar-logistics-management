using DTOLayer;

namespace BusinessLogicLayer
{
    public interface IDepartmentManager
    {
        void AddDepartment(DepartmentDTO department);
        void DeleteDepartment(int id);
        List<DepartmentDTO> GetAllDepartments();
        DepartmentDTO GetDepartmentById(int id);
        void UpdateDepartment(DepartmentDTO department);
    }
}