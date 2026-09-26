using DTOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AvailabilitySlot
    {
        public WorkingTime TimeSlot { get; private set; }
        
      
        public DateTime Date { get; private set; }
        
        public int ContractId { get; private set; }

        public AvailabilitySlot(WorkingTime timeSlot,  DateTime date, int contractId)
        {
            TimeSlot = timeSlot;
          
            Date = date;
            ContractId = contractId;
        }
    }
}
