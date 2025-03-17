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

        // Private constructor - use static methods to create
        private Result(bool isSuccess, T value, string error, ErrorDetails? errorDetails)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
            ErrorDetails = errorDetails;
        }

        public static Result<T> Success(T value) => new Result<T>(true, value, string.Empty, null);

        public static Result<T> Failure(string error) => new Result<T>(false, default!, error, null);

        public static Result<T> Failure(string error, ErrorDetails errorDetails) =>
            new Result<T>(false, default!, error, errorDetails);
    }


    public class Result
    {
        public bool IsSuccess { get; }
        public string Error { get; }
        public ErrorDetails? ErrorDetails { get; }

        private Result(bool isSuccess, string error, ErrorDetails? errorDetails)
        {
            IsSuccess = isSuccess;
            Error = error;
            ErrorDetails = errorDetails;
        }

        public static Result Success() => new Result(true, string.Empty, null);
        public static Result Failure(string error) => new Result(false, error, null);
        public static Result Failure(string error, ErrorDetails errorDetails) =>
            new Result(false, error, errorDetails);


        public static implicit operator bool(Result result) => result.IsSuccess;
    }

    public class ErrorDetails
    {
        public string Code { get; set; } = string.Empty;
        public Dictionary<string, string[]> ValidationErrors { get; set; } = new();
    }
}