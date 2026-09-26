using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using DataAccessLayer;

namespace MediaBazaar
{
	public class EmployeeWorksheetManager
	{
		public List<EmployeeWorksheet> assignedWorksheets { get; private set; }
        public WorksheetDAL worksheetDAL { get; private set; }

		public EmployeeWorksheetManager()
		{
			assignedWorksheets = new List<EmployeeWorksheet>();
			worksheetDAL = new WorksheetDAL();
		}

        public void CreateWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, int employee, int weekNr)
		{
			EmployeeWorksheet worksheet = new EmployeeWorksheet(timeSlot, weekDay, employee, weekNr);
			assignedWorksheets.Add(worksheet);
		}

        public void CreateWorksheet(int Id, WorkingTime timeSlot, WeekDayEnum weekDay, int employee, int weekNr)
        {
            EmployeeWorksheet worksheet = new EmployeeWorksheet(Id, timeSlot, weekDay, employee, weekNr);
            assignedWorksheets.Add(worksheet);
        }

        public void DeleteWorksheet(EmployeeWorksheet worksheet)
		{
			assignedWorksheets.Remove(worksheet);
		}

		public List<EmployeeWorksheet> ViewEmployeeWorksheets()
		{
			return assignedWorksheets;
		}

		public void AssignWorksheetsToEmployees(List<EmployeeWorksheet> worksheets)
		{
			assignedWorksheets.AddRange(worksheets);
		}

        public bool CanAssignWorksheet(int employeeId, WeekDayEnum weekDay, WorkingTime timeSlot)
        {
            var sameDayWorksheets = assignedWorksheets.Where(w => w.employee == employeeId & w.weekDay == weekDay).ToList();
            if (sameDayWorksheets.Count >= 2)
            {
                return false;
            }
            if (sameDayWorksheets.Count == 1)
            {
                var existingTimeSlot = sameDayWorksheets[0].timeSlot;
                if (!IsAdjacentTimeSlot(existingTimeSlot, timeSlot))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CanAssignWorksheet(int employeeId, WeekDayEnum weekDay, WorkingTime timeSlot, int weekNr)
        {
            var sameDayAndWeekWorksheets = assignedWorksheets.Where(w => w.employee == employeeId & w.weekDay == weekDay & w.weekNr == weekNr).ToList();
            if (sameDayAndWeekWorksheets.Count >= 2)
            {
                return false;
            }
            if (sameDayAndWeekWorksheets.Count == 1)
            {
                var existingTimeSlot = sameDayAndWeekWorksheets[0].timeSlot;
                if (!IsAdjacentTimeSlot(existingTimeSlot, timeSlot))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsAdjacentTimeSlot(WorkingTime slot1, WorkingTime slot2)
        {
            return Math.Abs(slot1 - slot2) == 1;
        }

        public EmployeeWorksheet TransformDTOToWorksheet(WorksheetDTO worksheetDTO)
		{
			
			if (worksheetDTO != null)
			{
                EmployeeWorksheet worksheet = new EmployeeWorksheet(worksheetDTO.Id, (WorkingTime)worksheetDTO.TimeSlot, (WeekDayEnum)worksheetDTO.WeekDay, worksheetDTO.EmployeeId, worksheetDTO.WeekNr);
				return worksheet;
			}
            throw new ArgumentNullException(nameof(worksheetDTO));
        }

		public WorksheetDTO TransformWorksheetToDTO(EmployeeWorksheet worksheet)
		{
			WorksheetDTO worksheetDTO = new WorksheetDTO(worksheet.id, (int)worksheet.timeSlot, (int)worksheet.weekDay, worksheet.employee, worksheet.weekNr);
			return worksheetDTO;
		}

		public void GetAllWorksheetsInDB()
		{
			assignedWorksheets.Clear();
			List<WorksheetDTO>worksheets = worksheetDAL.GetAllWorksheets();
			foreach (WorksheetDTO worksheet in worksheets)
			{
				assignedWorksheets.Add(TransformDTOToWorksheet(worksheet));
			}
		}

		public void UpdateWorksheetInDB(EmployeeWorksheet worksheet)
		{
			if(worksheet != null)
			{
                worksheetDAL.UpdateWorksheet(TransformWorksheetToDTO(worksheet));
				return;
            }
            throw new Exception("Worksheet was null");
		}

        public void UnassignWorksheet(EmployeeWorksheet worksheet)
        {
            if (worksheet != null)
            {
				worksheet.nullifyEmployee();
                worksheetDAL.UpdateWorksheet(TransformWorksheetToDTO(worksheet));
            }
            else
            {
                throw new Exception("Worksheet was null");
            }
        }

        public void DeleteWorksheetInDB(EmployeeWorksheet worksheet)
		{
			if (worksheet != null)
				worksheetDAL.DeleteWorksheet(worksheet.id);
		}

        public EmployeeWorksheet GetWorksheetById(int worksheetId)
        {
            return assignedWorksheets.FirstOrDefault(worksheet => worksheet.id == worksheetId);
        }


        public void AddWorksheetToDB(EmployeeWorksheet worksheet)
		{
			if(worksheet != null)
			{
                worksheetDAL.CreateWorksheet(TransformWorksheetToDTO(worksheet));
				return;
            }
			throw new Exception("Worksheet was null");
		}

        public void UnassignAllWorksheetsOfEmployee(int employeeId)
        {
            var employeeWorksheets = assignedWorksheets.Where(w => w.employee == employeeId).ToList();
            foreach (var worksheet in employeeWorksheets)
            {
                UnassignWorksheet(worksheet);
            }
        }


        public int GetNextId()
		{
			return worksheetDAL.GetNextWorksheetId();
		}
	}
}