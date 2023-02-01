using System;

namespace LC_UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            x1 = 1; x2 = 2; y1 = 3; y2 = 4;

            var L1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length of Line 1 is: " + L1);

            var L2 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine("Length of Line 2 is: " + L2);

            if(L1.CompareTo(L2) == 0)
            {
               Console.WriteLine("Length of Line 1 is Equals to Length of Line 2");
            }
            if (L1.CompareTo(L2) != 0)

            {
                Console.WriteLine("Length of Line 1 is Not Equals to Length of Line 2");
            }
        }
    }
}
