namespace Notifier
{
    internal class Program
    {
        static void Main()
        {
            var emailService = new EmailService();
            var emailServiceAdapter = new EmailServiceAdapter(emailService);

            var notifier = new NotificationService(emailServiceAdapter);

            notifier.SendNotification("This message needs to be sent");
        }
    }
}
