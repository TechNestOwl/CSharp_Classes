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
    public class Dentist : Person
    {
        private int dentId;
        private string officeNo;

        // Default constructor
        public Dentist() : base()
        {
            dentId = 0;
            officeNo = "";
        }

        // Parameterized constructor
        public Dentist(int dentId, string firstName, string lastName, string phone, string email, string officeNo)
            : base(firstName, lastName, phone, email)
        {
            this.dentId = dentId;
            this.officeNo = officeNo;
        }

        // Set methods
        public void setDentId(int id)
        {
            dentId = id;
        }

        public void setOfficeNo(string office)
        {
            officeNo = office;
        }

        // Get methods
        public int getDentId()
        {
            return dentId;
        }

        public string getOfficeNo()
        {
            return officeNo;
        }

        // Override display method
        public override void display()
        {
            Console.WriteLine($"Dentist ID: {dentId}");
            base.display(); // Call Person's display method
            Console.WriteLine($"Office Number: {officeNo}");
        }
    }
}
