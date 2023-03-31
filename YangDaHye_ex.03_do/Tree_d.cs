using System;

namespace YangDaHye_ex._03_do
{
    class Tree_d
    {
        static void Main(string[] args)
        {
            int a = 5;
            do
            {
                int b = 0;
                do
                {
                    Console.Write("*");
                    b++;
                } while (b < a);
                Console.WriteLine();
                a--;
            } while (a > 0);
        }

    }

}