﻿using System.Diagnostics;

namespace CityInfo.Api.Services
{
    public class LocalMailService : IMailService
    {
        private string _mailTo = "sample@test.com";
        private string _mailFrom = "sample2@test.com";

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
