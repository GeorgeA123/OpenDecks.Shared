namespace OpenDecks.Shared.DTOs.Requests.Application
{
    public class PatchApplicationDto
    {
        public string Status { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
    }
}