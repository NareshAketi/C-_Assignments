using System;

namespace Area_and_Circumference
{
    public class Area_and_Circumference
    {
        public static void A_and_c(float R)
        {
            float Area, Circumference, pie=3.14F;
            Area = pie * R * R;
            Console.WriteLine("Area of Circle {0}", Area);
            Circumference = 2 * pie * R;
            Console.WriteLine("Circumference of Circle {0}", Circumference);
        }
        static void Main(string[] args)
        {
            float R;
            Console.WriteLine("Enter Circle Radius: ");
            R = Single.Parse(Console.ReadLine());
            A_and_C(R);
        }
    }
}