/*********
    Gill Guimaraes
    Lab  #13
**********/

namespace MyClasses
{
    public class Patient
    {
        private int patId;
        private string firstName;
        private string lastName;
        private string email;
        private string insCo;

        private Address addr = new Address();
        private MyDate admitDate = new MyDate();

        public Patient()
        {
            patId = 0;
            firstName = "";
            lastName = "";
            email = "";
            insCo = "";
            addr = new Address();
            admitDate = new MyDate();
        }
        public Patient(int patId, string firstName, string lastName, string email, string insCo, Address addr, MyDate admitDate)
        {
            this.patId = patId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.insCo = insCo;
            this.addr = addr;
            this.admitDate = admitDate;
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

        // lab 12: new set methods
        public void setAdmitDate(MyDate d)
        {
            admitDate = d;
        }

        public void setAddr(Address a)
        {
            addr = a;
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

        //Lab 12: new get methods

        public MyDate getAdmitDate()
        {
            return admitDate;
        }


        public Address getAddr()
        {
            return addr;
        }

        // Display method
        public void display()
        {
            Console.WriteLine($"Patient ID: {patId}");
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Insurance Company: {insCo}");
            Console.WriteLine("Address Information:");
            addr.display();
            Console.WriteLine("Admission Date:");
            admitDate.display();
        }
    }
}
