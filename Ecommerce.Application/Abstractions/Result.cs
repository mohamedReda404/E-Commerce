using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Abstractions
{
    public class Result
    {
        public Result(bool issuccess,Error _error)
        {
            if((issuccess&&error!=Error.None)|| (!issuccess && error == Error.None))
            {
                throw new InvalidOperationException();
            }
            IsSuccess = issuccess;
            error = _error;
        }

        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;
        public Error error { get; } = default!;
        public static Result Success() => new Result(true,Error.None);
        public static Result Failure(Error error) => new Result(false, error);
        public static Result<Tvalue> Success<Tvalue>(Tvalue value) => new(value, true, Error.None);
        public static Result<Tvalue> Failure<Tvalue>(Error error) => new(default!,false,error);
    }

    public class Result<Tvalue> : Result
    {
        private readonly Tvalue _value;
        public Result(Tvalue value,bool issuccess, Error _error) : base(issuccess, _error)
        {
            _value= value;
        }
    }
}
