namespace myjinxin
{
    using System;

    public class Kata
    {
        public static int Multiply(int x) => x == 1 ? 1 : x * Multiply(x - 1);
        public static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Result for {0}: {1}", x, Multiply(x));
        }
    }
}