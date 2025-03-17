using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Requests
{
    public class CreateEventRequest
    {
        public string Name { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
    }
}
