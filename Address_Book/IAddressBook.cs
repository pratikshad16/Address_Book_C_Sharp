//-----------------------------------------------------------------------
// <copyright file="IAddressBook.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Address_Book
{
    using System;

    /// <summary>
    /// IAddressBook class
    /// </summary>
    public interface IAddressBook
    {
        /// <summary>
        /// Add method.
        /// </summary>
        public void Add();

        /// <summary>
        /// Display method.
        /// </summary>
        public void Display();

        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Edit(string firstName);

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Delete(string firstName);

        /// <summary>
        /// Sort method.
        /// </summary>
        public void Sort();

        /// <summary>
        /// View method.
        /// </summary>
        public void View();

        /// <summary>
        /// Search method.
        /// </summary>
        public void Search();
    }
}
