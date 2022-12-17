using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOnion.APPLICATION.Wrappers
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public int StatusCode { get; set; }
        public List<string>? Errors { get; set; }


        public static Result<T> Success(int statusCode, T data)
        {
            return new Result<T> { Data = data, StatusCode = statusCode };
        }
        public static Result<T> Success(int statusCode)
        {
            return new Result<T> { StatusCode = statusCode };
        }

        public static Result<T> Fail(int statusCode, List<string> errors)
        {
            return new Result<T> { StatusCode = statusCode, Errors = errors };
        }

        public static Result<T> Fail(int statusCode, string error)
        {
            return new Result<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }

        

    }
}