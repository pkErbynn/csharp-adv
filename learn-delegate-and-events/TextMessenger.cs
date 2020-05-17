using System;

namespace learn_delegate_and_events
{
    class TextMessenger
    {
        public void SendText(VideoEventArgs args)
        {
            Console.WriteLine("TextMessage: Sending message.... " + args.Video.Title);
        }

        public void SendMessageAfterVideoEncoding(object s, VideoEventArgs args)
        {
            SendText(args);
        } 
    }
}
