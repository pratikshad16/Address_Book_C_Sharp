using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBookImp : IAddressBook
    {
        Person person = null;
        List<Person> list = new List<Person>();
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
            list.Add(person);

        }

        public void display()
        {
            foreach (Person item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void edit(String firstName)
        {
            int check = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
                    {
                        Person person = list[i];
                        Console.WriteLine(person);
                        Console.WriteLine("Enter your choice for editing: ");
                        Console.WriteLine("1.Address 2.City 3.State 4.PhoneNumber 5.Zip  6.Exit");
                        String choice = Console.ReadLine();
                        int choice1 = Convert.ToInt32(choice);
                        switch (choice1)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                String address = Console.ReadLine();
                                person.Address = address;
                                break;
                            case 2:
                                Console.WriteLine("enter new city");
                                String city = Console.ReadLine();
                                person.City = city;
                                break;
                            case 3:
                                Console.WriteLine("enter new state");
                                String state = Console.ReadLine();
                                
                                person.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new phoneNo");
                                String phoneNumber = Console.ReadLine();
                               
                                person.PhoneNumber = phoneNumber;
                                break;

                            case 5:
                                Console.WriteLine("enter new zipCode");
                                String zipCode = Console.ReadLine();
                                
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
    }
}
