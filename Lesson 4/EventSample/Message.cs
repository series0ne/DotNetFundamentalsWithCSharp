namespace EventSample
{
    public class Message
    {
        public Message(string from, string to, string title, string text)
        {
            From = from;
            To = to;
            Title = title;
            Text = text;
        }

        public string From { get; }
        public string To { get; }
        public string Title { get; }
        public string Text { get; }
    }
}
