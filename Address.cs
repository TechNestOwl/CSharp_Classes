using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private int zipcode;

        // Constructor
        public Address()
        {
            street = "";
            city = "";
            state = "";
            zipcode = 0;
        }

        // Set methods
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
}
