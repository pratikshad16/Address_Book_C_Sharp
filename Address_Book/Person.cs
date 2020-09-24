//-----------------------------------------------------------------------
// <copyright file="Person.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Address_Book
{
    /// <summary>
    /// Person class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// firstName variable
        /// </summary>   
        private string firstName;

        /// <summary>
        /// lastName variable
        /// </summary>   
        private string lastName;

        /// <summary>
        /// address variable
        /// </summary>   
        private string address;

        /// <summary>
        /// city variable
        /// </summary>   
        private string city;

        /// <summary>
        /// state variable
        /// </summary>   
        private string state;

        /// <summary>
        /// phoneNumber variable
        /// </summary>   
        private string phoneNumber;

        /// <summary>
        /// zipCode variable
        /// </summary>   
        private string zipCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="firstName">first name.</param>
        /// <param name="lastName">last name.</param>
        /// <param name="address">address in string.</param>
        /// <param name="city">city in string</param>
        /// <param name="state">phone number.</param>
        /// <param name="phoneNumber">state in string.</param>
        /// <param name="zipCode">zip code.</param>
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

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        public string LastName { get => this.lastName; set => this.lastName = value; }

        /// <summary>
        /// Gets or sets distance
        /// </summary>
        public string FirstName { get => this.firstName; set => this.firstName = value; }

        /// <summary>
        /// Gets or sets Address
        /// </summary>
        public string Address { get => this.address; set => this.address = value; }

        /// <summary>
        /// Gets or sets City
        /// </summary>
        public string City { get => this.city; set => this.city = value; }

        /// <summary>
        /// Gets or sets State
        /// </summary>
        public string State { get => this.state; set => this.state = value; }

        /// <summary>
        /// Gets or sets PhoneNumber
        /// </summary>
        public string PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }

        /// <summary>
        /// Gets or sets ZipCode
        /// </summary>
        public string ZipCode { get => this.zipCode; set => this.zipCode = value; }

        /// <summary>
        /// string to string method.
        /// </summary>
        /// <returns>all parameters.</returns>
        public override string ToString()
        {
            return "[firstName=" + this.firstName + ", lastName=" + this.lastName + ", address=" + this.address + ", city=" + this.city
                 + ", state=" + this.state + ", zipCode=" + this.zipCode + ", PhoneNumber=" + this.phoneNumber + "]" + "\n";
        }
    }
}