using OpenDecks.Shared.DTOs.Responses.Brand;

namespace OpenDecks.Shared.DTOs.Responses.UserBrand
{
    public class UserBrandDto
    {
        public Guid UserId { get; set; }
        public Guid BrandId { get; set; }
        public string Role { get; set; } = string.Empty;

    }
}
