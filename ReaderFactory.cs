using CustomerReader.FileReader;
using CustomerReader.Model;
using System;

namespace CustomerReader
{
    public static class ReaderFactory
    {
        /// <summary>
        /// This method creates the instance of the customer files based on the input.
        /// </summary>
        public static CustomerReader GetCustomerReader(FileType type)
        {
            switch (type)
            {
                case FileType.Csv:
                    return new CSVReader();
                case FileType.Json:
                    return new JSONReader();
                case FileType.Xml:
                    return new XMLReader();
                default:
                    throw new ApplicationException(string.Format("This type of file can not be created"));
            }
        }

        /// <summary>
        /// This method creates the instance of the employee files based on input
        /// </summary>
        //public EmployeeReader GetEmployeeReader(FileType type)
        //{
        //    switch (type)
        //    {
        //        case FileType.Csv:
        //            return new CSVReader();
        //        case FileType.Json:
        //            return new JSONReader();
        //        case FileType.Xml:
        //            return new XMLReader();
        //        default:
        //            throw new ApplicationException(string.Format("This type of file can not be created"));
        //    }
        //}
    }
}
