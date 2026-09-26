using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class RestockRequestDTO
    {
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public string? ProductName { get; set; } 
        public int RequestedQuantity { get; set; }
        public string? Status { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string? SenderName { get; set; } 
    }
}
