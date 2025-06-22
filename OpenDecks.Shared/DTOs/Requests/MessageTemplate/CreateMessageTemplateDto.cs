namespace OpenDecks.Shared.DTOs.Requests.MessageTemplate
{
    public class CreateMessageTemplateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string MessageType { get; set; } = string.Empty;
        public Guid? BrandId { get; set; }
    }
}