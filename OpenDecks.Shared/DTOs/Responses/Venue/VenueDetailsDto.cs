namespace OpenDecks.Shared.DTOs.Responses.Venue
{
    public class VenueDetailsDto
    {
        public string PlaceId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string FormattedAddress { get; set; } = string.Empty;
        public string? InternationalPhoneNumber { get; set; }
        public string? FormattedPhoneNumber { get; set; }
        public string? Website { get; set; }
        public double? Rating { get; set; }
        public int? UserRatingsTotal { get; set; }
        public string? Url { get; set; }
        public string? UtcOffset { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public List<string> Types { get; set; } = new();
        public List<VenuePhotoDto> Photos { get; set; } = new();
        public VenueOpeningHoursDto? OpeningHours { get; set; }
        public bool WasSessionBased { get; set; } = false; // Indicates if this was a free session-based call
    }
}
