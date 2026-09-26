using MediaBazaar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace MediaBazaar
{
	public class EmployeeWorksheet
	{

		public int id { get; private set; } = 0;
		public WorkingTime timeSlot { get; private set; }
		public WeekDayEnum weekDay { get; private set; }
		public int? employee { get; private set; }
		public int weekNr { get; private set; }
		

		public EmployeeWorksheet(int Id,WorkingTime timeSlot, WeekDayEnum weekDay, int? employee, int weekNr)
		{
			this.id = Id;
			this.timeSlot = timeSlot;
			this.weekDay = weekDay;
			this.employee = employee;
			this.weekNr = weekNr;
		}

		public EmployeeWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, int? employee, int weekNr)
		{
			this.timeSlot = timeSlot;
			this.weekDay = weekDay;
			this.employee = employee;
			this.weekNr = weekNr;

		}
		public void nullifyEmployee()
		{
			employee = null;
        }

		public void UpdateWorksheet(WorkingTime timeSlot, WeekDayEnum weekDay, int? employee, int weekNr)
		{
            this.timeSlot = timeSlot;
            this.weekDay = weekDay;
            this.employee = employee;
            this.weekNr = weekNr;
        }
	}
}
