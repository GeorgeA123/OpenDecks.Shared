using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Responses.EventSeries
{
    public class EventSeriesDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public string EventTemplateName { get; set; } = string.Empty;

        public string EventTemplateDescription { get; set; }  = string.Empty;
        public string EventTemplateLocation { get; set; } = string.Empty;
        public Guid OrganizerId { get; set; }
        public string OrganizerName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public ICollection<Guid> EventIds { get; set; } = new List<Guid>();
    }
}
