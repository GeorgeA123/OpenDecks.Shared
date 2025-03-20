﻿namespace OpenDecks.Shared.DTOs.Requests
{
    public class CreateEventDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxApplicants { get; set; }
    }
}
