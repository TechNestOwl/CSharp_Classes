/*********
    Gill Guimaraes
    Lab  #13
**********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string phone;
        protected string email;

        // Default constructor
        public Person()
        {
            firstName = "";
            lastName = "";
            phone = "";
            email = "";
        }

        // Parameterized constructor
        public Person(string firstName, string lastName, string phone, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
        }

        // Set methods
        public void setFirstName(string f)
        {
            firstName = f;
        }

        public void setLastName(string l)
        {
            lastName = l;
        }

        public void setPhone(string p)
        {
            phone = p;
        }

        public void setEmail(string e)
        {
            email = e;
        }

        // Get methods
        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getEmail()
        {
            return email;
        }

        // Display method
        public virtual void display()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
