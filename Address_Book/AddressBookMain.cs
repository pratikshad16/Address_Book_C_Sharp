using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class AddressBookMain
    {
         static void Main(String[] args)
        {
            IAddressBook book = new AddressBookImp();
            Boolean check = true;
            while (check == true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1.Add a person 2.Display a person");
                String choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);

                switch (choice1)
                {
                    case 1:
                        book.add();
                        break;

                    case 2:
                        book.display();
                        break;
                }
            }
        }
    }
}

