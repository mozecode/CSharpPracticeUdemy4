using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Your job is to write a program for a speed camera. 
             For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             Write a program that asks the user to enter the speed limit. Once set, the program asks for the 
             speed of a car. If the user enters a value less than the speed limit, program should display Ok 
             on the console. If the value is above the speed limit, the program should calculate the number of 
             demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and
             displayed on the console. If the number of demerit points is above 12, the program should display 
             License Suspended.*/

            int userSpeed;
            int speedLimit;

            Console.WriteLine("Please enter the speed limit: ");
            while (int.TryParse(Console.ReadLine(), out speedLimit) == false || speedLimit < 0)
            {
                Console.WriteLine("Please try again:  ");
            }

            Console.WriteLine("Please enter the speed the car was traveling: ");
            while (int.TryParse(Console.ReadLine(), out userSpeed) == false || userSpeed < 0)
            {
                Console.WriteLine("Please try again:  ");
            }

            bool result = (userSpeed < speedLimit) ? true : false;

            if (result == true) //if they weren't speeding
            {
                Console.WriteLine("OK");
            }
            else//if they were speeding
            {
                Console.WriteLine("Hey, dumb cluck!  You were speeding.");
                var difference = userSpeed - speedLimit;
                int points = difference / 5;

                if (points >= 1 && points <= 11)
                {
                    Console.WriteLine("You have {0} points on your license.", points);
                }
                else if (points > 11)
                {
                    Console.WriteLine("Your license has been suspended.  You have at least 12 points.");
                }

            }
        }
    }
}
