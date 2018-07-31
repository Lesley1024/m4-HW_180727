using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4_7_課外作業_2_印出_九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int i = 1, j = 1;
            while (j <= 9)
            {
                while (i <= 9)
                {
                    if (i * j < 10)
                        Console.Write(i + "X" + j + "= " + i * j + "   ");
                    else
                    {
                        Console.Write(i + "X" + j + "=" + i * j + "   ");
                    }
                    i++;
                }
                Console.WriteLine();
                i = 1;
                j++;
            }
            Console.WriteLine("\n\n");
        }
    }

}
