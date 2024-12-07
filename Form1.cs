/*********
    Gill Guimaraes
    Lab  #13
**********/

namespace MyClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testAddress_btn_Click(object sender, EventArgs e)
        {
            //Address a1;
            //a1 = new Address(); 
            //a1.setStreet("123 Main Street");
            //a1.setCity("Dallas");
            //a1.setState("TX");
            //a1.setZipcode(54612);
            //a1.display();

            // Using the parameterized constructor
            Address a1 = new Address("123 Main St", "Dallas", "TX", 54612);
            a1.display();  //displaying the values passed to constructor
        }


        private void testPatient_btn_Click(object sender, EventArgs e)
        {
            // Creationg address for the patient
            Address patientAddr = new Address("123 Main St", "Kennesaw", "GA", 30127);

            // Creating admission date using the MyDate class
            MyDate admissionDate = new MyDate(11, 18, 2024);

            // creataing a new patient with al the properties
            Patient patient2 = new Patient(3098, "joe", "shmoe", "js@gnail.com",
                                        "Cigna", patientAddr, admissionDate);
            patient2.display();

            // get/set methods
            Console.WriteLine("Testing get/set methods:");

            // Get and display admission date
            MyDate currentDate = patient2.getAdmitDate();
            Console.WriteLine($"Current admission date is: {currentDate.getMonth()}/{currentDate.getDay()}/{currentDate.getYear()}");

            // Change admission date
            MyDate newDate = new MyDate(12, 25, 2024);
            patient2.setAdmitDate(newDate);
            Console.WriteLine("After changing admission date:");
            patient2.display();
        }

        private void testMyDate_btn_Click(object sender, EventArgs e)
        {
            //MyDate d1;
            //d1 = new MyDate(); 
            //d1.setMonth(11);
            //d1.setDay(4);
            //d1.setYear(2024);
            //d1.display();

            MyDate d1 = new MyDate(11, 4, 2024);
            d1.display();
        }

        private void personTestBtn_Click(object sender, EventArgs e)
        {
            Person person1 = new Person("Gill", "Guimaraes", "555-1234", "g.g@Gmail.com");
            Console.WriteLine("Testing Person class:");
            person1.display();

            Console.WriteLine("\nTesting get/set methods:");
            person1.setPhone("555-5678");
            Console.WriteLine($"New phone number: {person1.getPhone()}");
        }

        private void testDentistBtn_Click(object sender, EventArgs e)
        {
            Dentist dentist1 = new Dentist(1001, "Darth", "Vader", "555-9876", "d.v@dental.com", "Room 204");
            Console.WriteLine("Testing Dentist class:");
            dentist1.display();

            Console.WriteLine("\nTesting get/set methods:");
            dentist1.setOfficeNo("Room 205");
            Console.WriteLine($"New office number: {dentist1.getOfficeNo()}");
        }
    }
}
