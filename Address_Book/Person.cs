using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String phoneNumber;
        private String zipCode;
        public Person(string firstName, string lastName, string address, string city, string state, string phoneNumber, string zipCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
            this.zipCode = zipCode;
        }


        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Adderss { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PnoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }


        public override string ToString()
        {
            return "[firstName=" + firstName + ", lastName=" + lastName + ", address=" + address + ", city=" + city
                 + ", state=" + state + ", zipCode=" + zipCode + ", PhoneNumber=" + phoneNumber + "]" + "\n";
        }
    }
}

