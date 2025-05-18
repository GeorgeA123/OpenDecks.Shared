namespace OpenDecks.Shared.DTOs.Requests.Venue
{
    public class CreateVenueDto
    {
        public string Name { get; set; } = string.Empty;
        public string GooglePlaceId { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
    }
}
