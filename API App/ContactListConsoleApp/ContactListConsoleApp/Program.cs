using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactListClient = new DotNetQuickStart(
                new Uri(ConfigurationManager.AppSettings["API_APP_BASE_URI"])
                );

            var contacts = contactListClient.Contacts.Get();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.Name}, {contact.EmailAddress}");
            }

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
