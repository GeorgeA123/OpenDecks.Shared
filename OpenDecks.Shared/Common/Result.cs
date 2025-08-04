using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDecks.Shared.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string Error { get; }
        public ErrorDetails? ErrorDetails { get; }
        public ResultErrorType ErrorType { get; }

        // Private constructor - use static methods to create
        private Result(bool isSuccess, T value, string error, ErrorDetails? errorDetails, ResultErrorType errorType)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
            ErrorDetails = errorDetails;
            ErrorType = errorType;
        }

        public static Result<T> Success(T value) => new Result<T>(true, value, string.Empty, null, ResultErrorType.None);

        public static Result<T> Failure(string error) => new Result<T>(false, default!, error, null, ResultErrorType.Application);

        public static Result<T> Failure(string error, ResultErrorType errorType) => new Result<T>(false, default!, error, null, errorType);

        public static Result<T> Failure(string error, ErrorDetails errorDetails) =>
            new Result<T>(false, default!, error, errorDetails, ResultErrorType.Validation);

        public static Result<T> Failure(string error, ErrorDetails errorDetails, ResultErrorType errorType) =>
            new Result<T>(false, default!, error, errorDetails, errorType);
    }


    public class Result
    {
        public bool IsSuccess { get; }
        public string Error { get; }
        public ErrorDetails? ErrorDetails { get; }
        public ResultErrorType ErrorType { get; }

        private Result(bool isSuccess, string error, ErrorDetails? errorDetails, ResultErrorType errorType)
        {
            IsSuccess = isSuccess;
            Error = error;
            ErrorDetails = errorDetails;
            ErrorType = errorType;
        }

        public static Result Success() => new Result(true, string.Empty, null, ResultErrorType.None);
        public static Result Failure(string error) => new Result(false, error, null, ResultErrorType.Application);
        public static Result Failure(string error, ResultErrorType errorType) => new Result(false, error, null, errorType);
        public static Result Failure(string error, ErrorDetails errorDetails) =>
            new Result(false, error, errorDetails, ResultErrorType.Validation);
        public static Result Failure(string error, ErrorDetails errorDetails, ResultErrorType errorType) =>
            new Result(false, error, errorDetails, errorType);


        public static implicit operator bool(Result result) => result.IsSuccess;
    }

    public class ErrorDetails
    {
        public string Code { get; set; } = string.Empty;
        public Dictionary<string, string[]> ValidationErrors { get; set; } = new();
    }
}