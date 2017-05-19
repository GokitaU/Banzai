using System;

namespace Banzai.Api.Common.Exceptions
{
    public class RestException : Exception
    {
        public RestException(string message) : base(message)
        {
        }

        public RestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}