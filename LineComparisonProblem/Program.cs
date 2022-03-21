using System;

namespace LineComparisonProblem
{
    public class LineComparison
    {
        ///variables
        public double length_Of_Line;

        public interface ILine
        {
            public void Calc();
        }


    }
    public class Program : LineComparison
    {

        ///method for calculation
        public void Calc(double x1, double y1, double x2, double y2)
        {
            double X = Math.Pow(x2 - x1, 2.0);
            double Y = Math.Pow(y2 - y1, 2.0);
            length_Of_Line = Math.Sqrt(X + Y);
        }
        public static void Main(String[] args)
        {
            /// creating object 1 and reading input from user
            Program p = new Program();
            Console.WriteLine("enter line 1 values x1,y1,x2,y2 values\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            p.Calc(a, b, c, d);
            Console.WriteLine("Line1 Length is = " + p.length_Of_Line);

            /// creating object 2 and reading input from user
            Program p2 = new Program();
            Console.WriteLine("Enter Sencond line values x1,y1,x2,y2\n");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            p2.Calc(e, f, g, h);
            Console.WriteLine("Line 2 Length is = " + p2.length_Of_Line);
            ///comparing both line values to if its equal Returns True if equal else False
            Console.WriteLine("Checking lines are equal the answer is");
            Console.WriteLine((p.length_Of_Line).Equals(p2.length_Of_Line));
            ///comparing both line values to find line 1 is greater than line 2 Returns "1" if line 1 is greater then line, if line 1 is less than line 2 "-1"
            Console.WriteLine("Compairing line 1 to line 2 \nif returned 1 :line 1 is greater than line 2\nif returned -1 :line 1 is less than line 2");
            Console.WriteLine((p.length_Of_Line).CompareTo(p2.length_Of_Line));
        }

    }
}

