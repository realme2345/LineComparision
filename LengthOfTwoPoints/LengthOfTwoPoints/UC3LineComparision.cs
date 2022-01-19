using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC3LineComparision
    {
        public static double DisplayUC3()
        {
            Console.WriteLine("Enter value of X1 of first point(X1,Y1): "); //Intialising the values from user
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of Y1 of first point(X1,Y1): ");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of X2 of second  point(X2,Y2): ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of Y2 of second point(X2,Y2): ");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            // calculation of length between two points
            return Math.Sqrt(Math.Pow(X2 - X1, 2) +
                Math.Pow(Y2 - Y1, 2) * 1.0);
        }
        public static void ComparisionUC3()
        {
            string comparision = "";
            Console.WriteLine("Insert data for 1st line: ");
            double line1Length = DisplayUC3();
            Console.WriteLine("Insert data for 2nd line: ");
            double line2Length = DisplayUC3();
            if (line1Length > line2Length)
            {
                Console.WriteLine("line1Length is Greater than line2Length");
            }
            else if (line2Length < line1Length)
            {
                Console.WriteLine("line2Length is Greater than line1Length");
            }
            else
            {
                Console.WriteLine("line1Length equal to line2Length");
            }
            
        }
    }
}

