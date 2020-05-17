using System;
using System.Threading;

namespace learn_delegate_and_events
{
    public class VideoEncoder
    {
        // Publisher, publishing an event....
        // 1. Define delegate
        // 2. Define event based on that delegate
        // 3. Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);  // 1 => shape of method to be called in subscriber

        public event VideoEncodedEventHandler VideoEncoded;  // 2 

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);

            OnVideoEncoded();  // 3 
        }

        public virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)  // there is a subscriber
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}