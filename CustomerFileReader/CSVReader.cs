using CustomerReader.Model;
using System;
using System.IO;

namespace CustomerReader.FileReader
{
    public class CSVReader : CustomerReader
    {        
        public override void LoadData(String filePath)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement closes the StreamReader.
                using (StreamReader sr = new StreamReader(File.Open(filePath, FileMode.Open)))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] attributes = line.Split(',');
                        if (attributes[0] != "email")
                        {
                            Customer customer = new Customer
                            {
                                Email = attributes[0],
                                FirstName = attributes[1],
                                LastName = attributes[2],
                                Address =
                                {
                                    StreetAddress = attributes[4],
                                    City = attributes[5],
                                    State = attributes[6],
                                    ZipCode = attributes[7]
                                }
                            };
                            dataList.Add(customer);
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("OH NO!!!!");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
