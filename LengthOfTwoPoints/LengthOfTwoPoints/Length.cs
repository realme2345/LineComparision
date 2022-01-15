using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfTwoPoints
{
    class Length
    {
        // Function to calculate distance
         public static void Distance()
         {
            Console.WriteLine("Enter value of X1 of first point(X1,Y1): "); //Intialising the values from user
            double X1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of Y1 of first point(X1,Y1): ");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of X2 of second  point(X2,Y2): ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of Y2 of second point(X2,Y2): ");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            // calculation of length between two points
            Console.WriteLine("Result");
            double Length= Math.Sqrt(Math.Pow(X2 - X1, 2) +
                Math.Pow(Y2 - Y1, 2) * 1.0);
            Console.WriteLine("Length of Two points ({0},{1}) and ({2},{3}) is :{4}",X1,Y1,X2,Y2,Length);

         }
    }
}
