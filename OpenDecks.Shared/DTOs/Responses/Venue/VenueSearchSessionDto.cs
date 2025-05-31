namespace OpenDecks.Shared.DTOs.Responses.Venue
{
    public class VenueSearchSessionDto
    {
        public string SessionToken { get; set; } = string.Empty;
        public DateTime SessionExpiry { get; set; }
        public IEnumerable<VenueSearchResultDto> Venues { get; set; } = new List<VenueSearchResultDto>();
    }
}