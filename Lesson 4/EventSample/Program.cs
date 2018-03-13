namespace EventSample
{
    using System;

    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            MessagePublisher messagePublisher = new MessagePublisher();

            messagePublisher.MessageSent += MessageSentSubscriberAlice;
            messagePublisher.MessageSent += MessageSentSubscriberBob;

            messagePublisher.SendMessage("Charlie", "Alice", "Free cupcakes", "Get a free cupcake from the kitchen.");
            messagePublisher.SendMessage("Darren", "Bob", "Hello", "Welcome to the team!");

            Console.Read();
        }

        private static void MessageSentSubscriberBob(object sender, MessageEventArgs e)
        {
            if (e.Message.To == "Bob")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{e.Message.From} sent {e.Message.To} a message. The message titled '{e.Message.Title}' reads...");
                Console.WriteLine(e.Message.Text);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The message wasn't for me!");
            }
        }

        private static void MessageSentSubscriberAlice(object sender, MessageEventArgs e)
        {
            if (e.Message.To == "Alice")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{e.Message.From} sent {e.Message.To} a message. The message titled '{e.Message.Title}' reads...");
                Console.WriteLine(e.Message.Text);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The message wasn't for me!");
            }
        }
    }
}
