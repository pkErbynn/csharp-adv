using System;
using System.Threading;

namespace learn_delegate_and_events
{
    public class VideoEncoder
    {
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);
        }
    }
}
