using OpenDecks.Shared.DTOs.Requests.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Requests
{
    public class SubmitApplicationDto
    {
        public Guid EventId { get; set; }
        public Guid FormId { get; set; }
        public AnonymousUserInfo? AnonymousUser { get; set; }
        public List<ApplicationFieldResponseDto> Responses { get; set; } = new();
    }

    public class ApplicationFieldResponseDto
    {
        public Guid FormFieldId { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}