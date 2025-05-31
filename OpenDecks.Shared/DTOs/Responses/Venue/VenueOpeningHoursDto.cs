using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Responses.Venue
{
    public class VenueOpeningHoursDto
    {
        public bool OpenNow { get; set; }
        public List<string> WeekdayText { get; set; } = new();
    }
}
