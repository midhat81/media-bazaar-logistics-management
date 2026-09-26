using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;
using DataAccessLayer;
using MediaBazaar.Classes;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;

namespace BusinessLogicLayer
{
	public class AvailabilityManager
	{
		public AvailabilitySlotDAL availabilityDAL { get; private set; }
		public List<AvailabilitySlot> slots { get; private set; }
		public List<AvailabilitySlotDTO> slotsDTO { get; private set; }

		public AvailabilityManager()
		{
			availabilityDAL = new AvailabilitySlotDAL();
			slots = new List<AvailabilitySlot>();
			slotsDTO = new List<AvailabilitySlotDTO>();
			GetAllAvailabilitySlots();
		}

		public void AddAvailabilitySlot(AvailabilitySlot slot)
		{
			availabilityDAL.CreateSlot(TransformSlotToDTO(slot));
			slots.Add(slot);
		}

		public void AddAvailabilitySlot(AvailabilitySlotDTO slot)
		{
			availabilityDAL.CreateSlot(slot);
			slots.Add(TransformDTOToSlot(slot));
		}

		public void AddAvailabilitySlots(List<AvailabilitySlot> Slots)
		{
			foreach (AvailabilitySlot s in Slots)
			{
				availabilityDAL.CreateSlot(TransformSlotToDTO(s));
			}
			slots.AddRange(Slots);
		}

		public void AddAvailabilitySlots(List<AvailabilitySlotDTO> Slots)
		{
			foreach (AvailabilitySlotDTO s in Slots)
			{
				availabilityDAL.CreateSlot(s);
				slots.Add(TransformDTOToSlot(s));
			}
		}

		public void GetAllAvailabilitySlots()
		{
			slots.Clear();
			foreach (AvailabilitySlotDTO dto in availabilityDAL.GetAvailabilitySlots())
			{
				slots.Add(TransformDTOToSlot(dto));
			}
		}

		public void GetAllAvailabilitySlotsDTO()
		{
			slotsDTO.Clear();
            foreach (AvailabilitySlotDTO dto in availabilityDAL.GetAvailabilitySlots())
            {
                slotsDTO.Add(dto);
            }
        }



		public AvailabilitySlot TransformDTOToSlot(AvailabilitySlotDTO dto)
		{
			return new AvailabilitySlot((WorkingTime)dto.TimeSlotID ,dto.Date,dto.ContractID);
		}

		public AvailabilitySlotDTO TransformSlotToDTO(AvailabilitySlot slot)
		{
			return new AvailabilitySlotDTO(slot.ContractId, (int)slot.TimeSlot, slot.Date);
		}

		public List<AvailabilitySlot> GetContractSlots(int contractid)
		{
			List<AvailabilitySlot> contractslots = new List<AvailabilitySlot>();
			foreach (AvailabilitySlot s in slots)
			{
				if (s.ContractId == contractid)
					contractslots.Add(s);
			}
			return contractslots;
		}

        public List<AvailabilitySlotDTO> GetContractSlotsAsDTO(int contractid)
        {
			GetAllAvailabilitySlotsDTO();
            List<AvailabilitySlotDTO> contractslots = new List<AvailabilitySlotDTO>();
			try
			{
				foreach (AvailabilitySlotDTO s in slotsDTO)
				{
					if (s.ContractID == contractid)
						contractslots.Add(s);
				}
			}
			catch (Exception ex)
			{
				return null;
			}
            return contractslots;
        }

        public void UpdateSlots(List<AvailabilitySlotDTO> slots, int contractID,DateTime currentMonth, DateTime specificMonth)
        {
            availabilityDAL.DeleteAvailabilitySlots(contractID,currentMonth,specificMonth);
            AddAvailabilitySlots(slots);
        }
    }
}
