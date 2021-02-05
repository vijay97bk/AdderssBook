using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            string[] Name = new string[20];
            string[] Address = new string[50];
            string[] City = new string[20];
            string[] State = new string[20];
            string[] ZipCode = new string[6];
            string[] PhoneNumber = new string[12];
            string[] EmailID = new string[20];

            Console.WriteLine("Enter Name");
            Name[1] = Console.ReadLine();
            Console.WriteLine("enter Address");
            Address[1] = Console.ReadLine();
            Console.WriteLine("enter City");
            City[1] = Console.ReadLine();
            Console.WriteLine("enter State");
            State[1] = Console.ReadLine();
            Console.WriteLine("enter Zip code");
            ZipCode[1] = Console.ReadLine();
            Console.WriteLine("enter Phone number");
            PhoneNumber[1] = Console.ReadLine();
            Console.WriteLine("enter Email-Id");
            EmailID[1] = Console.ReadLine();
           

        }
    }
}
