

namespace OpenDecks.Shared.DTOs.Responses.Venue
{
    public class VenueSearchResultDto
    {
        public string PlaceId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Types { get; set; } = string.Empty;
        public double? Rating { get; set; }
        public int? UserRatingsTotal { get; set; }
        public string? FormattedPhoneNumber { get; set; }
        public string? Website { get; set; }
        public bool? OpenNow { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
