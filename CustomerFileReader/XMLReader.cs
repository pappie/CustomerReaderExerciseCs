using CustomerReader.Model;
using System;
using System.Xml;

namespace CustomerReader.FileReader
{
    public class XMLReader : CustomerReader
    {
        public override void LoadData(String filePath)
        {
            var doc = new XmlDocument();
            try
            {
                doc.Load(filePath);

                XmlNodeList nList = doc.GetElementsByTagName("Customer");

                for (int temp = 0; temp < nList.Count; temp++)
                {
                    XmlNode nNode = nList[temp];

                    if (nNode.NodeType == XmlNodeType.Element)
                    {
                        Customer customer = new Customer();
                        XmlElement eElement = (XmlElement)nNode;

                        customer.Email = eElement.GetElementsByTagName("Email").Item(0).InnerText;
                        customer.FirstName = eElement.GetElementsByTagName("FirstName").Item(0).InnerText;
                        customer.LastName = eElement.GetElementsByTagName("LastName").Item(0).InnerText;

                        XmlElement aElement = (XmlElement)eElement.GetElementsByTagName("Address").Item(0);

                        customer.Address.StreetAddress = aElement.GetElementsByTagName("StreetAddress").Item(0).InnerText;
                        customer.Address.City = aElement.GetElementsByTagName("City").Item(0).InnerText;
                        customer.Address.State = aElement.GetElementsByTagName("State").Item(0).InnerText;
                        customer.Address.ZipCode = aElement.GetElementsByTagName("ZipCode").Item(0).InnerText;

                        dataList.Add(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OH NO!!!!");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
