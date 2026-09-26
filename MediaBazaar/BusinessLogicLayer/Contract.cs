using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DTOLayer;

namespace MediaBazaar.Classes
{
	public class Contract
	{
		public int Id { get; private set; }
		public Role role {  get; private set; }
        public Department department { get; private set; }
		public decimal hourlyWage { get; private set; }
		public int weeklyHours { get; private set; }
		public DateTime startDate { get; private set; }
		public DateTime? endDate { get; private set; }
		public bool isActive { get; private set; }
		public string? terminationReason { get; private set; }
        public List<AvailabilitySlot> Availability { get; private set; } = new List<AvailabilitySlot>();

        public Contract(int id, Role role, decimal hourlyWage, int weeklyHours, DateTime startDate, DateTime? endDate, bool isActive, string? terminationReason, Department department)
        {
            Id = id;
            this.role = role;
            this.hourlyWage = hourlyWage;
            this.weeklyHours = weeklyHours;
            this.startDate = startDate;
            this.endDate = endDate;
            this.isActive = isActive;
            this.terminationReason = terminationReason;
            this.department = department;   
        }

        public void UpdateTerminationReason(string terminationReason)
        {
            this.terminationReason = terminationReason;
        }
        public void UpdateEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }
        public void UpdateIsActive(bool isActive)
        {
            this.isActive = isActive;
        }

        public void AddAvailabilitySlot(AvailabilitySlot slot)
        {
			Availability.Add(slot);
		}

		public void AddAvailabilitySlot(List<AvailabilitySlot> slot)
		{
			Availability.AddRange(slot);
		}
	}
}
