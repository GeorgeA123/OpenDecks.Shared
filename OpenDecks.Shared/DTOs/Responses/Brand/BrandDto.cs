using OpenDecks.Shared.DTOs.Responses.Event;
using OpenDecks.Shared.DTOs.Responses.UserBrand;

namespace OpenDecks.Shared.DTOs.Responses.Brand
{
    public class BrandDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<EventDto> Events { get; set; } = new List<EventDto>();
        public List<UserBrandDto> UserBrands { get; set; } = new List<UserBrandDto>();
    }
}
