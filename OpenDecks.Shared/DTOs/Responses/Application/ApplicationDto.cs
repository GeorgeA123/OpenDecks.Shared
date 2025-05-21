

using OpenDecks.Shared.DTOs.Responses.Application;
using OpenDecks.Shared.DTOs.Responses.Event;

namespace OpenDecks.Shared.DTOs.Responses
{
    public class ApplicationDto
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public Guid FormId { get; set; }
        public Guid ApplicantId { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string ApplicantName { get; set; } = string.Empty;
        public List<ApplicationResponseDto> Responses { get; set; } = new();

        public EventDto Event { get; set; }
    }
}