namespace CustomerReader.Model
{
    public class Customer  
    {
        public Customer()
        {
            Address = new Address();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public Address Address;
    }

}
