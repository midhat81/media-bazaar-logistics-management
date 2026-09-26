using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class AvailabilitySlotDTO
    {
        public int ContractID { get; set; }
       
        public int TimeSlotID {  get; set; }
        public DateTime Date {  get; set; }
        public bool IsSelected { get; set; }

        public AvailabilitySlotDTO() { }

        public AvailabilitySlotDTO(int contractID,  int timeSlotID, DateTime date)
        {
            ContractID = contractID;
           
            TimeSlotID = timeSlotID;
            Date = date;
        }

        public AvailabilitySlotDTO(int contractID, int timeSlotID, DateTime date, bool selected)
        {
            ContractID=contractID;
            TimeSlotID = timeSlotID;
            Date = date;
            IsSelected = selected;
        }
    }
}
