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
            Console.WriteLine("Print All Contacts in PhoneBook:");
            PrintAllContacts(30);

            Console.WriteLine("Print Needed Contacts:");
            PrintConcreteContacts("093",30);
            




            Console.ReadLine();
        }

        static void PrintAllContacts(int count)
        {
            var contacts = new PhoneBook();
            var listContacts = contacts.GetContacts(count);
            foreach (var contact in listContacts)
            {
                Console.WriteLine($"{contact.Name} {contact.SurName} { contact.PhoneNum}");
            }
        }

        static void PrintConcreteContacts(string str, int count)
        {
            var contacts = new PhoneBook();
            var listContacts = contacts.GetConcreteOperatorContacts(str, count);
            foreach (var contact in listContacts)
            {
                Console.WriteLine($"{contact.Name} {contact.SurName} { contact.PhoneNum}");
            }
        }


    }
}
