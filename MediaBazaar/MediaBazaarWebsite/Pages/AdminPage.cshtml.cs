using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class AdminPageModel : PageModel
    {
        internal EmployeeManager _employeeManager;
        public int Hired1Month;
        public int Hired3Month;
        public int Hired6Month;
        public int Hired1Year;
        public int Deactivated;
        public int Fired1Month;
        public int Fired3Month;
        public int Fired6Month;
        public int Fired1Year;
        public AdminPageModel(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
            Hired1Month = _employeeManager.HiredInTimeFrame(1);
            Hired3Month = _employeeManager.HiredInTimeFrame(3);
            Hired6Month= _employeeManager.HiredInTimeFrame(6);
            Hired1Year=_employeeManager.HiredInTimeFrame(12);
            Deactivated = _employeeManager.DeactivatedEmployees();
            Fired1Month= _employeeManager.FiredInTimeFrame(1);
            Fired3Month = _employeeManager.FiredInTimeFrame(3);
            Fired6Month = _employeeManager.FiredInTimeFrame(6);
            Fired1Year = _employeeManager.FiredInTimeFrame(12);

        }

        public void OnGet()
        {

        }

        
    }
}
