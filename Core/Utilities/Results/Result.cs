using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static Result FromSuccess(string message = null)
            => new Result(true, message);

        public static Result FromError(string message = null)
            => new Result(false, message);
    }
}
