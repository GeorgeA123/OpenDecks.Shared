namespace OpenDecks.Shared.Common;

public enum ResultErrorType
{
    /// <summary>Default error type when none is specified</summary>
    None = 0,
    
    /// <summary>Validation errors (400 Bad Request)</summary>
    Validation = 1,
    
    /// <summary>Authentication/Authorization errors (401 Unauthorized)</summary>
    Unauthorized = 2,
    
    /// <summary>Forbidden access errors (403 Forbidden)</summary>
    Forbidden = 3,
    
    /// <summary>Resource not found errors (404 Not Found)</summary>
    NotFound = 4,
    
    /// <summary>Conflict errors, e.g., resource already exists (409 Conflict)</summary>
    Conflict = 5,
    
    /// <summary>Business logic errors (422 Unprocessable Entity)</summary>
    BusinessLogic = 6,
    
    /// <summary>External service errors (502 Bad Gateway)</summary>
    ExternalService = 7,
    
    /// <summary>General application errors (500 Internal Server Error)</summary>
    Application = 8
}