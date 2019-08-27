using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class Bisect
    {
        public int usernum = 0;
        public int UserInput()
        {
            Console.Write("Enter a number from 1 to 10: ");
            try
            {
                int usernum = Int32.Parse(Console.ReadLine());
                if (usernum > 0 && usernum < 11)
                {
                    return usernum;
                }
                else
                {
                    //Console.Clear();
                    Console.Write("Invalid Input. Enter a number from 1 to 10:");
                    Console.ReadLine();
                    UserInput();
                    return usernum;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Invalid Input. Enter a number from 1 to 10:");
                Console.ReadLine();
                UserInput();
                
            }

            return usernum;
        }
        public void Bisection(int usernum, int[] list)
        {
            int first = list[0];
            int last = list[list.Length - 1];
            int middle = 0;
            int count = 0;

            while (list[middle] != usernum)
            {
                middle = (first + last) / 2;
                if (list[middle] > usernum)
                {

                    count++;
                    last = middle - 1;

                    Console.WriteLine($"The range of numbers is {first} - {last}");
                    Console.WriteLine($"Your number is less than {middle}.");
                }
                else if (list[middle] < usernum)
                {
                    count++;
                    first = middle + 1;
                    Console.WriteLine($"The range of numbers is {first} - {last}");
                    Console.WriteLine($"Your number is more than {middle}.");
                }

            }

            Console.WriteLine($"It took {count} iterations to find {usernum}.");
        }
    }
}
