using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Responses.Venue
{
    public class VenuePhotoDto
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string PhotoReference { get; set; } = string.Empty;
        public List<string> HtmlAttributions { get; set; } = new();
    }
}
