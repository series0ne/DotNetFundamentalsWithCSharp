namespace EventSample
{
    using System;

    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(Message message)
        {
            Message = message;
        }

        public Message Message { get; }
    }
}
