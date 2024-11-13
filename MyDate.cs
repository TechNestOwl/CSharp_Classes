/*********
    Gill Guimaraes
    Lab  #10
**********/

namespace MyClasses
{
    public class MyDate
    {
        private int month;
        private int day;
        private int year;

        // Constructor
        public MyDate()
        {
            month = 1;
            day = 1;
            year = 2024;
        }

        public MyDate(int month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }

        // Set methods
        public void setMonth(int m)
        {
            month = m;
        }

        public void setDay(int d)
        {
            day = d;
        }

        public void setYear(int y)
        {
            year = y;
        }

        // Get methods
        public int getMonth()
        {
            return month;
        }

        public int getDay()
        {
            return day;
        }

        public int getYear()
        {
            return year;
        }

        // Display method
        public void display()
        {
            Console.WriteLine($"Date: {month}/{day}/{year}");
        }
    }
}
