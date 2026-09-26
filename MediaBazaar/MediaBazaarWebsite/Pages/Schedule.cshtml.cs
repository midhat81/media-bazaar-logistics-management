using DTOLayer;
using MediaBazaar;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using System.Security.Claims;

namespace MediaBazaarWebsite.Pages
{
    public class ScheduleModel : PageModel
    {
        private EmployeeManager _employeeManager;
        private EmployeeWorksheetManager _worksheetManager;
        public ScheduleModel(EmployeeManager employeeManager, EmployeeWorksheetManager worksheetManager)
        {
            _employeeManager = employeeManager;
            _worksheetManager = worksheetManager;
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<EmployeeWorksheet> Worksheets { get; set; } = new List<EmployeeWorksheet>();
        public void OnGet()
        {
            var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (idClaim != null)
            {
                int id = int.Parse(idClaim.Value);
                var employee = _employeeManager.GetEmployeeById(id);
                if (employee != null)
                {
                    FirstName = employee.FirstName;
                    LastName = employee.LastName;
                    _worksheetManager.GetAllWorksheetsInDB();
                    Worksheets = _worksheetManager.assignedWorksheets.Where(w => w.employee == id).ToList();
                }
            }
        }
        public static string WeekNumberToMonthAndWeek(int weekNumber)
        {
            int year = DateTime.Now.Year;
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            var weekNum = weekNumber;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            int month = result.Month;
            int weekOfMonth = result.Day / 7 + 1;
            return $"Month: {month}, Week of Month: {weekOfMonth}";
        }
    }
}
