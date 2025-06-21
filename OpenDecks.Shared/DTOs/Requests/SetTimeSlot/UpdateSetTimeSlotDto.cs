namespace OpenDecks.Shared.DTOs.Requests.SetTimeSlot
{
    public class UpdateSetTimeSlotDto
    {
        public Guid Id { get; set; }
        public Guid? ApplicantId { get; set; }
        public string SlotNotes { get; set; } = string.Empty;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}