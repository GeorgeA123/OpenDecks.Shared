using OpenDecks.Shared.DTOs.Responses.Form;
using OpenDecks.Shared.DTOs.Responses.Venue.VenueDto;

namespace OpenDecks.Shared.DTOs.Responses.Event
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxApplicants { get; set; }
        public string Status { get; set; } = string.Empty;
    
        public string ImageUrl { get; set; } = string.Empty;
        public Guid OrganizerId { get; set; }
        public string OrganizerName { get; set; } = string.Empty;
        public Guid? BrandId { get; set; }
        public string? BrandName { get; set; } = string.Empty;
        public Guid? EventSeriesId { get; set; }
        
        public VenueDto? Venue { get; set; }

        public FormDto? Form { get; set; }
    }
}
