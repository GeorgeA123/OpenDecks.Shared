using OpenDecks.Shared.Enums;
using System.Text.Json;

namespace OpenDecks.Shared.DTOs.Responses.Application
{
    public class ApplicationResponseDto
    {
        public Guid Id { get; set; }
        public Guid FormFieldId { get; set; }
        public string FieldLabel { get; set; } = string.Empty;
        public string FieldType { get; set; } = string.Empty;
        public string ResponseValue { get; set; } = string.Empty;
        public ResponseType ResponseType { get; set; } = ResponseType.String;

        public object GetTypedValue()
        {
            switch (ResponseType)
            {
                case ResponseType.Number:
                    return decimal.TryParse(ResponseValue, out var numValue) ? numValue : null;

                case ResponseType.DateTime:
                    return DateTime.TryParse(ResponseValue, out var dateValue) ? dateValue : null;

                case ResponseType.JsonArray:
                    try
                    {
                        return JsonSerializer.Deserialize<List<string>>(ResponseValue);
                    }
                    catch
                    {
                        return ResponseValue;
                    }

                case ResponseType.Email:
                case ResponseType.Phone:
                case ResponseType.FileReference:
                case ResponseType.String:
                default:
                    return ResponseValue;
            }
        }

        public string GetDisplayValue()
        {
            if (string.IsNullOrEmpty(ResponseValue))
                return "Not provided";

            switch (ResponseType)
            {
                case ResponseType.DateTime:
                    return DateTime.TryParse(ResponseValue, out var date)
                        ? date.ToString("g") // Short date and time
                        : ResponseValue;

                case ResponseType.JsonArray:
                    try
                    {
                        var options = JsonSerializer.Deserialize<List<string>>(ResponseValue);
                        return options != null ? string.Join(", ", options) : ResponseValue;
                    }
                    catch
                    {
                        return ResponseValue;
                    }

                default:
                    return ResponseValue;
            }
        }
    }
}
