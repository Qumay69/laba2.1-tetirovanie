using System;

namespace LogicExpressions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("X | Y | Z | Expression 1 | Expression 2");
            for (int X = 0; X <= 1; X++)
            {
                for (int Y = 0; Y <= 1; Y++)
                {
                    for (int Z = 0; Z <= 1; Z++)
                    {
                        bool expr1 = Expression1(X, Y, Z);
                        bool expr2 = Expression2(X, Y, Z);

                        Console.WriteLine($"{X} | {Y} | {Z} | {Convert.ToInt32(expr1)} | {Convert.ToInt32(expr2)}");
                    }
                }
            }
        }
        public static bool Expression1(int X, int Y, int Z)
        {
            return !(X == 1 && Y == 1) || (X == 1 && Z == 0);
        }

        public static bool Expression2(int X, int Y, int Z)
        {
            return (X == 1 && (Y == 0 || Z == 1)) || Y == 1;
        }
    }
}
