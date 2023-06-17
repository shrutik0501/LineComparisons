using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coordinates of the First Line
            double x1 = 0;
            double y1 = 0;
            double x2 = 5;
            double y2 = 5;
            //coordinate of the Second Line
            double x3 = 0;
            double y3 = 0;
            double x4 = 10;
            double y4 = 10;
            //calculating the lengths of the two lines
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            if (length1 == length2) 
            {
                Console.WriteLine("The two lines are equal");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("The first line is greater than second line");
            }
            else
            {
                Console.WriteLine("The second line is greater than the first line");
            }
        }
    }
}
