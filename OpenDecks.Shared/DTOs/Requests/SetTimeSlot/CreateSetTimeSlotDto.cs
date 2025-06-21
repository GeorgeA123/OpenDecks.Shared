namespace OpenDecks.Shared.DTOs.Requests.SetTimeSlot
{
    public class CreateSetTimeSlotDto
    {
        public Guid? ApplicantId { get; set; }
        public Guid EventId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string SlotNotes { get; set; } = string.Empty;
    }
}