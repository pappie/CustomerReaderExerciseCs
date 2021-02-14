using CustomerReader.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace CustomerReader.FileReader
{
    public class JSONReader : CustomerReader
    {        
        public override void LoadData(String filePath)
        {
            try
            {
                //Initializing the Json text reader.
                JsonTextReader reader = new JsonTextReader(File.OpenText(filePath));

                //Reading content using the reader and storing in a Json array.
                JArray jArray = (JArray)JToken.ReadFrom(reader);

                //Loop for accessing every Json object from the Json array.
                foreach (JObject jObject in jArray)
                {
                    //Reading parent Json objects.
                    JObject record = jObject;
                    //Reading child Json objects.
                    JObject address = (JObject)record["Address"];
                    //Assigning the Json object values to a new Customer object property and adding it to the Customer List.
                    Customer customer = new Customer
                    {
                        Email = (String)record["Email"],
                        FirstName = (String)record["FirstName"],
                        LastName = (String)record["LastName"],
                        Address = {
                            StreetAddress = (String)address["StreetAddress"],
                            City = (String)address["City"],
                            State = (String)address["State"],
                            ZipCode = (String)address["ZipCode"]
                        }
                    };
                    dataList.Add(customer);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (JsonException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
