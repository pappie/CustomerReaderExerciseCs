using CustomerReader.Model;
using System;

namespace CustomerReader
{
    class Program
    {
        //declare the files folder path
        private static readonly string filePath = "..\\..\\doc\\";

        static void Main(string[] args)
        {            
            //Get the instance of csv type file
            IDataReader<Customer> csvReader = ReaderFactory.GetCustomerReader(FileType.Csv);
            //load the data from the gievn path
            csvReader.LoadData(filePath + "customers.csv");

            //Get the instance of csv json file
            IDataReader<Customer> jsoneader = ReaderFactory.GetCustomerReader(FileType.Json);
            //load the data from the gievn path
            jsoneader.LoadData(filePath + "customers.json");

            //Get the instance of csv xml file
            IDataReader<Customer> xmlReader = ReaderFactory.GetCustomerReader(FileType.Xml);
            //load the data from the gievn path
            xmlReader.LoadData(filePath + "customers.xml");

            //get the total count of all 3 files data
            int count = csvReader.getCount() + jsoneader.getCount() + xmlReader.getCount();
            Console.WriteLine("Added this many customers: " + count + "\n");

            //display the customer data from 3 files
            csvReader.DisplayData();
            jsoneader.DisplayData();
            xmlReader.DisplayData();

            Console.ReadLine();
        }
    }


}
