using System;

namespace lineOfLengthProblems
{
    class lengthoflines
    {
        public static double Main()
        {

            Console.Write("Value of the X1:");
            double valueOfX1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the X2:");
            double valueOfY1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the Y1:");
            double valueOfX2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value of the Y2:");
            double valueOfY2 = Convert.ToDouble(Console.ReadLine());
            double lengthOfALine = (int)(Math.Pow(valueOfX2 - valueOfY1, 2) + Math.Pow(valueOfX2 + valueOfY1, 2));
            return lengthOfALine;
            //Console.WriteLine(lengthOfALine);
        }

    }
}