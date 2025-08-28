namespace Notifier
{
    public class NotificationService
    {
        private readonly INotifier _notifier;

        public NotificationService(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void SendNotification(string message)
        {
            _notifier.Notify(message);
        }
    }
}
