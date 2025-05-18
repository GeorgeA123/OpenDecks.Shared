using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Requests.Application
{
    public class UpdateApplicationDto
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<UpdateApplicationResponseDto> Responses { get; set; } = new List<UpdateApplicationResponseDto>();
    }
}
