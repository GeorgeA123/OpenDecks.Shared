using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Requests.Event
{
    public class CreateEventInSeriesDto
    {
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }


        public string? Name { get; set; }
        public string? Location { get; set; }
        public int? MaxApplicants { get; set; }
    }
}
