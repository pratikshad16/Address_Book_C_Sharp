using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBookImp : IAddressBook
    {
        Person person = null;
        LinkedList<Person> list = new LinkedList<Person>();
        public void add()
        {
            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            String address = Console.ReadLine();

            Console.WriteLine("Enter city");
            String city = Console.ReadLine();

            Console.WriteLine("Enter state");
            String state = Console.ReadLine();

            Console.WriteLine("Enter phoneNumber");
            String phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            String zipCode = Console.ReadLine();

            person = new Person(firstName, lastName, address, city, state, phoneNumber, zipCode);
            list.AddFirst(person);

        }

        public void display()
        {
            foreach (Person item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
