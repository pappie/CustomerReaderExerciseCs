using CustomerReader.Extensions;
using CustomerReader.Model;
using System;
using System.Collections.Generic;

namespace CustomerReader
{
    /// <summary>
    /// Base class for customer reader
    /// </summary>
    public abstract class CustomerReader : IDataReader<Customer>
    {
        #region Variables

        public List<Customer> dataList { get; set; }

        #endregion variables

        #region Constructor

        public CustomerReader()
        {
            dataList = new List<Customer>();
        }

        #endregion Constructor

        #region non abstract methods

        /// <summary>
        /// This method display the customer data
        /// </summary>
        /// 
        public void DisplayData()
        {
            foreach (Customer customer in dataList)
            {
                String customerString = "";
                customerString += "Email: " + customer.Email.ToLower() + "\n";
                customerString += "First Name: " + customer.FirstName.FirstLetterToUpper() + "\n";
                customerString += "Last Name: " + customer.LastName.FirstLetterToUpper() + "\n";
                customerString += "Full Name: " + customer.FullName.FirstLetterToUpper() + "\n";
                customerString += "Street Address: " + customer.Address.StreetAddress.FirstLetterToUpper() + "\n";
                customerString += "City: " + customer.Address.City.FirstLetterToUpper() + "\n";
                customerString += "State: " + customer.Address.State.ToUpper() + "\n";
                customerString += "Zip Code: " + customer.Address.ZipCode + "\n";
                Console.WriteLine(customerString);
            }
        }

        /// <summary>
        /// This method give the count of customers
        /// </summary>
        /// 
        public int GetCount()
        {
            return dataList.Count;
        }

        #endregion non abstract methods

        #region abstract methods

        /// <summary>
        /// This method load the data from the given file path
        /// </summary>
        public abstract void LoadData(String filePath);

        #endregion

    }
}
