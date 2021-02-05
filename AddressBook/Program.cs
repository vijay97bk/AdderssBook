using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        public static List<Person> People = new List<Person>();
        static void Main(string[] args)
        {
            int Choice;
            
            Console.WriteLine("1:Add nwe details");
            Console.WriteLine("2:edit Details");
            Console.WriteLine("3:Delete details");
            Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                   AddPerson();
                    break;
                case 3:
                    RemovePerson();
                    break;
                case 2:
                    editPeople();
                    break;
             
                default:
                    break;
                   
            }
        }
        private static void AddPerson()
        {
            Console.Clear();

            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }

    }
}
