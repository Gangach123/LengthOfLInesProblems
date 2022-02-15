using System;

namespace lineOfLengthProblems
{
    class lengthoflines
    {
        public static void Main1()
        {
            Console.WriteLine("Enter Co-ordinates of 1st Line");
            double lengthOfALine = Main();
            Console.WriteLine("Enter Co-ordinates of 2nd Line");
            double lengthOfALine1 = Main();
            int result = lengthOfALine.CompareTo(lengthOfALine1);
            switch(result)
            {
                case 0:
                    Console.WriteLine("Two lines are equal");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater than Line 2");
                    break;
                default:
                    Console.WriteLine("Line 2 is greater than Line 1");
                    break;
            }

        }
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