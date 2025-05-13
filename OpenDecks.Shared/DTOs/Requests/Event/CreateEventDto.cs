namespace OpenDecks.Shared.DTOs.Requests.Event
{
    public class CreateEventDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxApplicants { get; set; }
        public string ImageUrl { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? EventSeriesId { get; set; }
    }
}
