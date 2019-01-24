using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730484
{
    public class customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public void promote()
        {
            var rating = calculaterating();
            if (rating == 0)
            { Console.WriteLine("Promoted to level 1"); }
            else
            {//commit again
                Console.WriteLine("Level 2");
            }
        }
        public int calculaterating()
        {
            return 0;
        }

    }
    class Program

    {
        static void Main(string[] args)
        {
            var customer = new customer();
            //var dog_and_cat = new car();
            //var bowlimng = new car();
            //Console.WriteLine("How many cars: {0}",vehicle.howmanycars);
            //book mybook = new book();
            //mybook.SetTitle("A separate Peace");
            //Console.WriteLine(mybook.GetTitle());
        }
    }
    class vehicle

    {
        public static int howmanycars = 0;
        public String Color = "Blue";

    }
    class car : vehicle
    {
        public String Color = "Red";
        public car()
        {
            vehicle.howmanycars++;
            Console.WriteLine("my color is " + Color);
        }

    }
    class Bookcollection
    {

    }
    class book : Bookcollection
    {
        private String Title;
        public void SetTitle(String aTitle)
        {
            this.Title = aTitle;

        }
        public String GetTitle() { return this.Title; }
    }

}






