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

            }
            catch (Exception ex)
            {

                throw;
            }
            return new List<Video>();
        }
    }
}
