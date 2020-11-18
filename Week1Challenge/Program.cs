using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Challenge
{
    class Program
    {
        static void Main(string[] args)
       [TestMethod]
        public void NameAndAge()
        {
            string firstname = "Rafael";
            string lastname = "Rivera";
            int age = 45;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }
        [TestMethod]
        public void ListOfDates()
        {
            string[] movie = { "batman", "Die Hard", "little women" };

        }
        { 
            List<DateTime> listOfDates = new List<DateTime>();
        Datetime now = DateTime.Now;
        listOfDates.Add(today);
            listOfDates.add(new DateTime(2020,12,25));
            listOfDates.add(new DateTime(2020,3,12));
            }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
         { Console.WriteLine("How Much Sleep Did You get?????");
        int hours = 4;
        if (hours >= 10)
        {
            Console.WriteLine("Wow, that is a lot of sleep"); ;
        }

        else if (hours >= 8 && hours < 10)
        {
            Console.WriteLine("You Should Be Well Rested");

        }
        else if (hours > 4 && hours < 8)
        {
            Console.WriteLine("Bummer");

        }
        else
        {
            Console.WriteLine("Oh man get some sleep");
        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userday = "Okay";
            switch (userday)
            {
                case "Great":
                    Console.WriteLine("That is Great");
                    break;
                case "Good":
                    Console.WriteLine("it is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hope it gets better");
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter something above");

            }
        }
    }[TestMethos]
    public void Supercalafragilistexpialidotioous()
    { string name = "Supercalafragilistexpialidotioous";
        foreach (char letter in name)
        {
            if (letter == 'i')
                Console.WriteLine((letter));
        }
        else
        { Console.WriteLine("not an i" ); 
        }
            ;
        }

}
   