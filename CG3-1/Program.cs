using System;

namespace CG3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name that month: ");
            Console.Write("Enter a number between 1 and 12: ");
            string monthName = Console.ReadLine();
            string message = " ";

            if (monthName == "1")
            {
                message = "January";
            }
            else if (monthName == "2")
            {
                message = "February";
   
            }
            else if (monthName == "3")
            {
                message = "March";
            }
        
            else if (monthName == "4")
            {
                message = "April";
            }
            else if (monthName == "5")
            {
                message = "May";
            }
            else if (monthName == "6")
            {
                message = "June";
            }
            else if (monthName == "7")
            {
                message = "July";
            }
            else if (monthName == "8")
            {
                message = "August";
            }
            else if (monthName == "9")
            {
                message = "September";
            }
            else if (monthName == "10")
            {
                message = "October";
            }
            else if (monthName == "11")
            {
                message = "November";
            }
            else if (monthName == "12")
            {
                message = "December";
            }
            else
            {
                message = "That month doesn't exist. Try again.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }


    }
}
