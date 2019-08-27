using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            int[] list = new int[10]
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Bisect bi = new Bisect();
            int usernum = bi.UserInput();
            bi.Bisection(usernum, list);
        }

        

        
    }
}
