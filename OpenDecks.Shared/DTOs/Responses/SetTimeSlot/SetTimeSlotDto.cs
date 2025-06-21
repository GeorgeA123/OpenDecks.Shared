namespace OpenDecks.Shared.DTOs.Responses.SetTimeSlot
{
    public class SetTimeSlotDto
    {
        public Guid Id { get; set; }
        public Guid? ApplicantId { get; set; }
        public Guid EventId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string SlotNotes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ApplicantName { get; set; }
        public string EventName { get; set; } = string.Empty;
    }
}