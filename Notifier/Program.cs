namespace Notifier
{
    internal class Program
    {
        static void Main()
        {
            var emailService = new EmailService();

            var notifier = new NotificationService(emailService);

            notifier.SendNotification("This message needs to be sent");
        }
    }
}
