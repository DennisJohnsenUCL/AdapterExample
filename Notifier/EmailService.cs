namespace Notifier
{
    internal class EmailService
    {
        public void SendEmail(string subject, string body)
        {
            Console.WriteLine($"Sending email with subject {subject} and body {body}");
        }
    }
}