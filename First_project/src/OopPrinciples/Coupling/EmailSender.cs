using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {

        public void SendNotification(string message)
        {
            // EMail sending logic
            System.Console.WriteLine("Sending email: " + message);
        }
    }
}
