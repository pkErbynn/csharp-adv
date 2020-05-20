using System;
namespace exception_handling
{
    class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) 
            : base(message, innerException)
        {

        }
    }
}
