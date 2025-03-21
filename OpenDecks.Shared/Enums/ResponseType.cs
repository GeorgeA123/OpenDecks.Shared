namespace OpenDecks.Shared.Enums
{
    public enum ResponseType
    {
        String,       // For Text, TextArea, Dropdown, RadioGroup
        Number,       // For Number
        DateTime,     // For Date, Time
        JsonArray,    // For Checkbox (multiple selections)
        Email,        // For Email
        Phone,        // For Phone
        FileReference // For FileUpload
    }
}