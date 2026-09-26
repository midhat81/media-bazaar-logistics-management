using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class WorksheetDTO
    {
        public int Id { get; private set; }
        public int TimeSlot {  get;private set; }
        public int WeekDay { get;private set; }
        public int? EmployeeId {  get; private set; }
        public int WeekNr {  get; private set; }

        public WorksheetDTO(int id, int timeSlot, int weekDay, int? employeeId, int weekNr)
        {
            Id = id;
            TimeSlot = timeSlot;
            WeekDay = weekDay;
            EmployeeId = employeeId;
            WeekNr = weekNr;
        }
    }
}
