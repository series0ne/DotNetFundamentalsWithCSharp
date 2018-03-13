namespace EventSample
{
    using System;

    public class MessagePublisher
    {
        public event EventHandler<MessageEventArgs> MessageSent;

        public void SendMessage(string from, string to, string title, string text)
        {
            Message message = new Message(from, to, title, text);
            
            if(MessageSent != null)
            {
                MessageSent(this, new MessageEventArgs(message));
            }
        }
    }
}
