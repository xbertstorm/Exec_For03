using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入三角形長度：");
            string thelength = Console.ReadLine();

            for (int i = int.Parse(thelength); i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = int.Parse(thelength); k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
