using System;

namespace LibForHire
{
    

    public class ClassForHire
    {
        public static double Tri(double x, double y, double z)
        {
            if ((x<0)||(y<0)||(z<0))
            {
                Console.WriteLine($"Input: Incorrect lengths of sides");
                return 0;
            }
            double p = ((x + y + z) / 2);
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            if ((x * x == (y * y) + (z * z)) || (y * y == (x * x) + (z * z)) || (z * z == (x * x) + (y * y)))
            {
                Console.WriteLine($"Input: Traingle has a 90 angle");
            }
            return (s);
        }

        public static double Circle(double r)
        {
            if (r<0)
            {
                Console.WriteLine($"Input: Incorrect lengths of radius");
                return 0;
            }
            return (Math.PI * Math.Pow(r, 2));
        }
    }
}
