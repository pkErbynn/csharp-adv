using System;

namespace learn_delegate_and_events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1 title" };
            var videoEncoder = new VideoEncoder();

            videoEncoder.Encode(video);
        }
    }
}
