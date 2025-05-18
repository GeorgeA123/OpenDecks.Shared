using OpenDecks.Shared.DTOs.Requests.Venue;

namespace OpenDecks.Shared.DTOs.Requests.Event
{
	public class PatchEventDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxApplicants { get; set; }
        public string Status { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public Guid? BrandId { get; set; }
		public Guid? VenueId { get; set; }

		public CreateVenueDto? Venue { get; set; }

	}
}
