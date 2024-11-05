
/***
 * Gill Guimaraes
 * Lab Asssignment #10
***/

using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Address a1;
            a1 = new Address(); //creates empty Address Object
            a1.setStreet("123 Main Street");
            a1.setCity("Dallas");
            a1.setState("TX");
            a1.setZipcode(54612);
            a1.display();
        }

        private void testPatient_btn_Click(object sender, EventArgs e)
        {
            Patient p1;
            p1 = new Patient(); //creates empty Patient Object
            p1.setPid(3098);
            p1.setFirstName("Frank");
            p1.setLastName("Martin");
            p1.setEmail("fm@gnail.com");
            p1.setInsCo("Cigna");
            p1.display();
        }

        private void testMyDate_btn_Click(object sender, EventArgs e)
        {
            MyDate d1;
            d1 = new MyDate(); //creates empty MyDate Object
            d1.setMonth(11);
            d1.setDay(4);
            d1.setYear(2024);
            d1.display();
        }
    }
}