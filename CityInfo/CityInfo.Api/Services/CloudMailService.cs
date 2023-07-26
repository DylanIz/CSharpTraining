namespace CityInfo.Api.Services
{
    public class CloudMailService : IMailService
    {
        private string _mailTo = "sample@test.com";
        private string _mailFrom = "sample2@test.com";

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(CloudMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
}   }

