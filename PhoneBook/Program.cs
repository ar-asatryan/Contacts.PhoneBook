using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase();
            var listContacts = db.GetContact(15);

            foreach (var contact in listContacts)
            {
                Console.WriteLine($"Contact{listContacts.IndexOf(contact) + 1}: {contact.Name} {contact.SurName} { contact.PhoneNum}");
            }

            Console.ReadLine();
        }
    }
}
