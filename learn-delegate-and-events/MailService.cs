using System;

namespace learn_delegate_and_events
{
    public class MailService
    {
        public void OnVideoEncodingDone(object source, EventArgs e)  // args not used....just to match delegate shape
        {
            Console.WriteLine("MailService: Sending an email....");
        }
    }
}