namespace Notifier
{
    public class EmailServiceAdapter : INotifier
    {
        private readonly EmailService _emailService;

        public EmailServiceAdapter(EmailService emailService)
        {
            _emailService = emailService;
        }

        public void Notify(string message)
        {
            _emailService.SendEmail("Notification", message);
        }
    }
}
