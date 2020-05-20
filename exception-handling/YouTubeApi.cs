using System;
using System.Collections.Generic;
namespace exception_handling
{
    class YouTubeApi
    {
        // creating custom exceptions not to expose lower level of ex
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Oops....some low level YouTube error. ");
            }
            catch (Exception ex)
            {

                throw new YouTubeException("Sorry....Could not fetch the videos from YouTube.", ex);
            }
            return new List<Video>();
        }
    }
}
