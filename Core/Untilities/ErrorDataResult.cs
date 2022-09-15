using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Untilities
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data, bool succes) : base(data, false)
        {

        }
        public ErrorDataResult(T data, bool succes, string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }

    }
}
