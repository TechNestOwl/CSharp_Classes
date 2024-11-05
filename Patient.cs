using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Patient
    {
        private int patId;
        private string firstName;
        private string lastName;
        private string email;
        private string insCo;

        // Constructor
        public Patient()
        {
            patId = 0;
            firstName = "";
            lastName = "";
            email = "";
            insCo = "";
        }

        // Set methods
        public void setPid(int id)
        {
            patId = id;
        }

        public void setFirstName(string f)
        {
            firstName = f;
        }

        public void setLastName(string l)
        {
            lastName = l;
        }

        public void setEmail(string e)
        {
            email = e;
        }

        public void setInsCo(string i)
        {
            insCo = i;
        }

        // Get methods
        public int getPid()
        {
            return patId;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getEmail()
        {
            return email;
        }

        public string getInsCo()
        {
            return insCo;
        }

        // Display method
        public void display()
        {
            Console.WriteLine($"Patient ID: {patId}");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Insurance Company: {insCo}");
        }
    }
}
