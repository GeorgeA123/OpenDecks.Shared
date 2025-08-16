namespace OpenDecks.Shared.DTOs.Requests.Form
{
    public class UpdateFormDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPublished { get; set; }
    }
}
