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

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);  // 1 => shape of method to be called in subscriber
        //public event VideoEncodedEventHandler VideoEncoded;  // 2 

        public event EventHandler<VideoEventArgs> VideoEncoded;     // replace step // 1 and // 2 ...... and pub additional data

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);  // 3 ... not changed when new sub is added....and publishing some data
        }

        public virtual void OnVideoEncoded(Video video)  // event should be virtual by convention
        {
            if (VideoEncoded != null)  // there is a subscriber
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }
}