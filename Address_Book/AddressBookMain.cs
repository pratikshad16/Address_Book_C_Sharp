//-----------------------------------------------------------------------
// <copyright file="AddressBookMain.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Address_Book
{
    using System;

    /// <summary>
    /// Address Book Main class
    /// </summary>
    public class AddressBookMain
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args">String argument</param>
        public static void Main(string[] args)
        {
            IAddressBook book = new AddressBookImp();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1.Add a person 2.Display a person 3. Edit a person 4. Delete a person 5. Sort a person 6. View a person 7. Search a person");
                string choice = Console.ReadLine();
                int choice1 = Convert.ToInt32(choice);

                switch (choice1)
                {
                    case 1:
                        book.Add();
                        break;

                    case 2:
                        book.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter firstName");
                        string name = Console.ReadLine();
                        book.Edit(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter firstName");
                        string nameForDeletion = Console.ReadLine();
                        book.Delete(nameForDeletion);
                        break;
                    case 5:
                        book.Sort();
                        break;
                    case 6:
                        book.View();
                        break;
                    case 7:
                        book.Search();
                        break;
                }
            }
        }
    }
}