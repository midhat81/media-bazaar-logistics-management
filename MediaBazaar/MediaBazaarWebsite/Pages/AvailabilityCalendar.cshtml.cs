using BusinessLogicLayer;
using DTOLayer;
using MediaBazaar.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using static System.Collections.Specialized.BitVector32;

namespace MediaBazaarWebsite.Pages
{
    public class AvailabilityCalendarModel : PageModel
    {
        [BindProperty]
        public List<AvailabilitySlotDTO> AvailabilitySlots { get; set; }

        private readonly AvailabilityManager _availabilityManager;
        private readonly ILogger<AvailabilityCalendarModel> _logger; // Add logger
        [BindProperty]
        public DateTime CurrentMonth { get; set; }

        public int ContractID { get; set; }

        public AvailabilityCalendarModel(IHttpContextAccessor httpContextAccessor, ILogger<AvailabilityCalendarModel> logger)
        {
            _availabilityManager = new AvailabilityManager();
            _logger = logger; 

            var user = httpContextAccessor.HttpContext?.User;
            if (user != null && user.Identity.IsAuthenticated)
            {
                var contractIdClaim = user.Claims.FirstOrDefault(c => c.Type == "ContractID")?.Value;
                if (!string.IsNullOrEmpty(contractIdClaim) && int.TryParse(contractIdClaim, out int contractId))
                {
                    ContractID = contractId;
                }
                else
                {
                    _logger.LogWarning("ContractID claim is missing or invalid.");
                }
            }
        }

        public void OnGet()
        {
            if (CurrentMonth == default)
            {
                CurrentMonth = DateTime.Today;
            }

            LoadAvailabilitySlots();
        }

        public IActionResult OnPost(string selectedMonth,string action)
        {
            if (!DateTime.TryParseExact(selectedMonth, "yyyy-MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedMonth))
            {
                parsedMonth = DateTime.Today;
            }
            CurrentMonth = parsedMonth;

            if (action == "previousMonth")
            {
                CurrentMonth = CurrentMonth.AddMonths(-1);
            }
            else if (action == "nextMonth")
            {
                CurrentMonth = CurrentMonth.AddMonths(1);
            }
            else if (action == "save")
            {
                var selectedSlots = AvailabilitySlots
                    .Where(slot => slot.IsSelected && slot.Date.Month == CurrentMonth.Month && slot.Date.Year == CurrentMonth.Year)
                    .ToList();

               
                var groupedSlots = selectedSlots
                    .GroupBy(slot => slot.Date)
                    .ToList();

                foreach (var group in groupedSlots)
                {
                    if (group.Count() > 2)
                    {
                        ModelState.AddModelError("", $"You cannot select more than 2 shifts for {group.Key.ToShortDateString()}.");
                        continue;
                    }

                    if (group.Count() == 2)
                    {
                        var timeSlotIds = group.Select(slot => slot.TimeSlotID).OrderBy(id => id).ToList();
                        if (timeSlotIds[1] - timeSlotIds[0] != 1)
                        {
                            ModelState.AddModelError("", $"Selected shifts for {group.Key.ToShortDateString()} must be continuous.");
                        }
                    }
                }

                if (!ModelState.IsValid)
                {
                    return Page();
                }

                
                _availabilityManager.UpdateSlots(selectedSlots, ContractID, DateTime.Now, CurrentMonth);
            }
            LoadAvailabilitySlots();
            return Page();
        }

        private void LoadAvailabilitySlots()
        {
            AvailabilitySlots = new List<AvailabilitySlotDTO>();

            DateTime startOfMonth = new DateTime(CurrentMonth.Year, CurrentMonth.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            List<AvailabilitySlotDTO> existingSlots = _availabilityManager.GetContractSlotsAsDTO(ContractID);

            if (existingSlots == null)
            {
                _logger.LogError("Failed to load existing availability slots from the database.");
                existingSlots = new List<AvailabilitySlotDTO>(); // Fallback to empty list
            }

            for (DateTime date = startOfMonth; date <= endOfMonth; date = date.AddDays(1))
            {
                for (int shift = 1; shift <= 3; shift++)
                {
                    var slot = new AvailabilitySlotDTO(ContractID, shift, date);
                    if (existingSlots.Any(e => e.Date == date && e.TimeSlotID == shift))
                    {
                        slot.IsSelected = true;
                    }
                    AvailabilitySlots.Add(slot);
                }
            }
        }

        public string GetWorkingTimeName (int timeSlotID)
        {
            WorkingTime time = (WorkingTime)timeSlotID;
            return time.ToString();
        }

        
    }
}
