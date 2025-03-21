﻿using OpenDecks.Shared.DTOs.Responses.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Responses.Event
{
    public class EventDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public string Location { get; set; } = string.Empty;
        public int MaxApplicants { get; set; }
        public string Status { get; set; } = string.Empty;
        public Guid OrganizerId { get; set; }
        public string OrganizerName { get; set; } = string.Empty;

        public FormDto? Form { get; set; }
    }
}
