using OpenDecks.Shared.DTOs.Responses.Brand;
using OpenDecks.Shared.DTOs.Responses.User;

namespace OpenDecks.Shared.DTOs.Responses.UserBrand
{
    public class UserBrandDto
    {
        public Guid UserId { get; set; }
        public Guid BrandId { get; set; }
        public string Role { get; set; } = string.Empty;
        public UserDto User {get;set;}

    }
}
