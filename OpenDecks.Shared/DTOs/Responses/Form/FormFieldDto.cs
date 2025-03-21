using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.DTOs.Responses.Form
{
    public class FormFieldDto
    {
        public Guid Id { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string FieldType { get; set; } = string.Empty;
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public string Options { get; set; } = string.Empty;
        public string ValidationRules { get; set; } = string.Empty;
    }
}