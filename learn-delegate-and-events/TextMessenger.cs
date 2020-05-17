using System;

namespace learn_delegate_and_events
{
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
