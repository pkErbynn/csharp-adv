using System;

namespace learn_delegate_and_events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1 title" };
            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService();  // subscriber
            var textMessenger = new TextMessenger();  // another sub

            // subscription is done before publishing

            videoEncoder.VideoEncoded += mailService.OnVideoEncodingDone;  // subscription process
            videoEncoder.VideoEncoded += textMessenger.SendMessageAfterVideoEncoding;  // another sub process

            videoEncoder.Encode(video);  // contains the event
        }
    }

    class TextMessenger
    {
        public void SendText()
        {
            Console.WriteLine("TextMessage: Sending message....");
        }

        public void SendMessageAfterVideoEncoding(object s, EventArgs e)
        {
            SendText();
        } 
    }
}
