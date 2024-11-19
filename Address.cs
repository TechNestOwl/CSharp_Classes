/*********
    Gill Guimaraes
    Lab  #12
**********/

namespace MyClasses
{
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private int zipcode;

        // constructor with no arguments and all values set to "" , 0
        public Address()
        {
            street = "";
            city = "";
            state = "";
            zipcode = 0;
        }

        //constructor that takes all 4 arguments
        public Address(string street, string city, string state, int zipcode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }

        // Set methods (no longer needed)
        public void setStreet(string s)
        {
            street = s;
        }

        public void setCity(string c)
        {
            city = c;
        }

        public void setState(string s)
        {
            state = s;
        }

        public void setZipcode(int z)
        {
            zipcode = z;
        }

        // Get methods
        public string getStreet()
        {
            return street;
        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }

        public int getZipcode()
        {
            return zipcode;
        }

        // Display method
        public void display()
        {
            Console.WriteLine($"Street: {street}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Zipcode: {zipcode}");
        }
    }
}

