using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Program
    {
        public static List<Person> People = new List<Person>();
        private static readonly Person person;

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
        private static void RemovePerson()
        {
            List<Person> people = FindPeopleByFirstName();

            Console.Clear();

            if (people.Count == 0)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            if (people.Count == 1)
            {
                People.Remove(person);
                Console.Clear();
                return;
            }

            Console.WriteLine("Enter the number of the person you want to remove");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(i);
                PrintPerson(people.ElementAt(i));
            }
            int removePersonNumber = Convert.ToInt32(Console.ReadLine());
            if (removePersonNumber > people.Count - 1 || removePersonNumber < 0)
            {
                Console.WriteLine("That number is invalid. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            RemovePersonFromList(people.ElementAt(removePersonNumber));
        }

        private static List<Person> FindPeopleByFirstName()
        {
            Console.Clear();
            Console.WriteLine("Enter the first name of the person you would like to find.");
            string firstName = Console.ReadLine();
            return People.Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
        }

        private static void RemovePersonFromList(Person person)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.Clear();
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }


    }
}
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string[] Addresses { get; set; }
    }



