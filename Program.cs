using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int wei = Convert.ToInt32(Console.ReadLine());

            if (wei >= 50)
            {
                Console.WriteLine("Package is to heavy to be shipped");
                Console.ReadLine();
                return;
            }

            else 
            {
                Console.WriteLine("Weight Accepted");
            }

            Console.WriteLine("Please enter the package height.");
            int hei = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package width.");
            int wid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length.");
            int len = Convert.ToInt32(Console.ReadLine());
            int Dim = hei + len + wid;
            if (Dim >= 50)

            {
                Console.WriteLine("Package is to big to be shiped via Package Express.");
                Console.ReadLine();
                return;

            }

            else  

            {
                Console.WriteLine("Dimensions Accepted!");

            }

            int totalDim = hei * wid * len;

            int total = totalDim * wei / 100;
            Console.WriteLine("Your estimated total for shipping this package is:  $" + total);
            Console.ReadLine();

        }
    }
}