using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class Program
    {
        int[] list = new int[10]
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        static void Main(string[] args)
        {
           
           



        }

        public int UserInput()
        {
            try
            {
                Console.Write("Enter a number from 1 to 10: ");
                int usernum = Int32.Parse(Console.ReadLine());
                return usernum;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Invalid Input. Enter a number from 1 to 10:");
                int usernum = Int32.Parse(Console.ReadLine());
                return usernum;
            }
            finally
            {
                Console.Clear();
                Console.Write("Invalid Input. Enter a number from 1 to 10:");
                int usernum = Int32.Parse(Console.ReadLine());
                
            }
            
        }

        public double Bisection(int usernum)
        {
            int first = list[list.Length];
            int last = list[list.Length - 1];
            int middle = first + last / 2;
            int count = 0;

            while (list[middle] != usernum)
            {
                count++;


            }

            Console.WriteLine($"{usernum} was the middle value in the array. It took {count} iterations to find your number!");


        }

        
    }
}
