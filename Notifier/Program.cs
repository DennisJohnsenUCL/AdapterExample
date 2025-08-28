using Microsoft.Extensions.DependencyInjection;

namespace Notifier
{
    internal class Program
    {
        static void Main()
        {
            var services = new ServiceCollection()
                .AddScoped<EmailService>()
                .AddScoped<INotifier, EmailServiceAdapter>()
                .AddScoped<NotificationService>()
                .BuildServiceProvider();

            var notifier = services.GetRequiredService<NotificationService>();

            notifier.SendNotification("This message needs to be sent");
        }
    }
}
