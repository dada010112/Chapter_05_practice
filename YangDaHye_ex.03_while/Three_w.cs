using System;

namespace YangDaHye_ex03_while
{
    class Three_w
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 5)
            {
                int b = 0;
                while (b <= a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}