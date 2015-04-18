using System;

namespace Neyro.Vk
{
    public class ApiException : Exception
    {
        public ApiError Error { get; set; }
        public ApiException(ApiError error)
            : base(error.Message)
        {
            this.Error = error;
        }
    }
}
