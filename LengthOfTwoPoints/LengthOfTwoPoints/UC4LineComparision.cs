using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UC4LineComparision
    {
        public static double DispalyUC4()
        {
             Console.Write("Insert x1 = ");
             int x1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Insert y1 = ");
             int y1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Insert x2 = ");
             int x2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Insert y2 = ");
             int y2 = Convert.ToInt32(Console.ReadLine());
             return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public static void ComparisionUC4()
       {
             string comparision = "";
             Console.WriteLine("Insert data for 1st line: ");
             double line1Length = LengthOfLine();
             Console.WriteLine("Insert data for 2nd line: ");
             double line2Length = LengthOfLine();
             if (line1Length > line2Length) comparision = "is greater than";
            else if (line1Length < line2Length) comparision = "is less than";
            else if (line1Length == line2Length) comparision = "is equals to";
            else
            {
               comparision = "unknown";
              Console.WriteLine($"Error: something went worng");
            }
        Console.WriteLine($"{line1Length} {comparision} {line2Length}");
    }
    
}
