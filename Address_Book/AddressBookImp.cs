//-----------------------------------------------------------------------
// <copyright file="AddressBookImp.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Address_Book
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// AddressBookImp class
    /// </summary>
    public class AddressBookImp : IAddressBook
    {
        /// <summary>
        /// Created a list.
        /// </summary>
        private readonly List<Person> list = new List<Person>();

        /// <summary>
        /// Assign person equals null. 
        /// </summary>
        private Person person = null;

        /// <summary>
        /// Add method.
        /// </summary>
        public void Add()
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    Console.WriteLine("Oops!! You entered the duplicate name");
                }
            }

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            string zipCode = Console.ReadLine();

            this.person = new Person(firstName, lastName, address, city, state, phoneNumber, zipCode);
            this.list.Add(this.person);
        }

        /// <summary>
        /// Display method.
        /// </summary>
        public void Display()
        {
            foreach (Person entry in this.list)
            {
                Console.WriteLine(entry);
            }
        }

        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Edit(string firstName)
        {
            int check = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
                    {
                        Person person = this.list[i];
                        Console.WriteLine(person);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.PhoneNumber 5.Zip  6.Exit");
                        string choice = Console.ReadLine();
                        int choice1 = Convert.ToInt32(choice);
                        switch (choice1)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                string address = Console.ReadLine();
                                person.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter new city");
                                string city = Console.ReadLine();
                                person.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter new state");
                                string state = Console.ReadLine();
                                person.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new phoneNumber");
                                string phoneNumber = Console.ReadLine();
                                person.PhoneNumber = phoneNumber;
                                break;

                            case 5:
                                Console.WriteLine("enter new zipCode");
                                string zipCode = Console.ReadLine();
                                person.ZipCode = zipCode;
                                break;

                            case 6:
                                check = 1;
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Delete(string firstName)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].FirstName.Equals(firstName))
                {
                    this.list[i] = null;
                }
            }

            Console.WriteLine("Your expected entry is deleted from records");
        }

        /// <summary>
        /// Sort method.
        /// </summary>
        public void Sort()
        {
            this.list.Sort(this.Compare);
            this.Display();
        }

        /// <summary>
        /// Compare method.
        /// </summary>
        /// <param name="x">first person name.</param>
        /// <param name="y">second person name.</param>
        /// <returns>comparison result.</returns>
        public int Compare(Person x, Person y)
        {
            Console.WriteLine("Enter choice for sorting:");
            Console.WriteLine("1. FirstName 2. City 3. State 4. Zip");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    return x.FirstName.CompareTo(y.FirstName);
                case 2:
                    return x.City.CompareTo(y.City);
                case 3:
                    return x.State.CompareTo(y.State);
                case 4:
                    return x.ZipCode.CompareTo(y.ZipCode);
                default:
                    break;
            }

            return 0;
        }

        /// <summary>
        /// View method.
        /// </summary>
        public void View()
        {
            Console.WriteLine("Enter your choice for viewing: ");
            Console.WriteLine("1. City 2. State");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your city");
                    string city = Console.ReadLine();
                    for (int i = 0; i < this.list.Count; i++)
                    {
                        if (this.list[i].City.Equals(city))
                        {
                            Console.WriteLine(this.list[i]);
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("Enter your state");
                    string state = Console.ReadLine();
                    for (int i = 0; i < this.list.Count; i++)
                    {
                        if (this.list[i].State.Equals(state))
                        {
                            Console.WriteLine(this.list[i]);
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// Search method.
        /// </summary>
        public void Search()
        {
            Console.WriteLine("Enter your choice for searching: ");
            Console.WriteLine("1. City 2. State");
            string choice = Console.ReadLine();
            int choice1 = Convert.ToInt32(choice);
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your name");
                    string nameToSearchInCity = Console.ReadLine();
                    for (int i = 0; i < this.list.Count; i++)
                    {
                        if (this.list[i].FirstName.Equals(nameToSearchInCity))
                        {
                            Console.WriteLine(this.list[i].City);
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("Enter your name");
                    string nameToSearchInState = Console.ReadLine();
                    for (int i = 0; i < this.list.Count; i++)
                    {
                        if (this.list[i].FirstName.Equals(nameToSearchInState))
                        {
                            Console.WriteLine(this.list[i].State);
                        }
                    }

                    break;
            }
        }
    }
}   