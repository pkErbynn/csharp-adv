using System;

namespace learn_delegate_and_events
{
    public class MailService
    {
        public void OnVideoEncodingDone(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email....");
        }
    }
}