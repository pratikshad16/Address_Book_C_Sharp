using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public interface IAddressBook
    {
        public void add();
        public void display();
        public void edit(String firstName);
        public void delete(String firstName);
        public void sort();
        public void view();
    }
}
