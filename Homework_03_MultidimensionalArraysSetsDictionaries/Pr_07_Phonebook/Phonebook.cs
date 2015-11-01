using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_07_Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            Dictionary<string, List<string>> contacts = new Dictionary<string, List<string>>();
            
            while (input1 != "search")
            {
                string[] contactNum = input1.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = contactNum[0];
                string phoneNumber = contactNum[1];
                if (!contacts.ContainsKey(name))
                {
                    contacts[name] = new List<string>();
                }
                contacts[name].Add(phoneNumber);

                input1 = Console.ReadLine();
            }

            string contactToSearch = Console.ReadLine();

            while (!String.IsNullOrEmpty(contactToSearch))
            {
                if (contacts.ContainsKey(contactToSearch))
                {
                    Console.WriteLine("{0} -> {1}", contactToSearch, String.Join(", ", contacts[contactToSearch]));
                }
                else
                {
                    Console.WriteLine("Contact " + contactToSearch + " does not exist.");
                }
                contactToSearch = Console.ReadLine();
            }
        }
    }
}
