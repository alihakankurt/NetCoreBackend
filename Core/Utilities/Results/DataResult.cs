using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public static DataResult<T> FromSuccess(T data, string message = null)
            => new DataResult<T>(data, true, message);

        public static DataResult<T> FromError(T data, string message = null)
            => new DataResult<T>(data, false, message);
    }
}
