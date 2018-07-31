using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4_10_課外作業_5_印出_質數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("本程式重複檢測: 輸入數字是否為質數。(請輸入負數或0結束程式)");
            ConsoleColor originalColor = Console.ForegroundColor;
            while (true)
            {
                Console.WriteLine();
                Console.Write("請輸入欲檢測數字:");

                int numToCheck = int.Parse(Console.ReadLine());

                int i = 2;
                if (numToCheck <= 0) { Console.WriteLine("\n===============程式結束===============\n"); break; }

                while (i < numToCheck)
                {
                    if (numToCheck == 2) break;
                    if (numToCheck % i == 0) break;

                    i++;
                }

                if (i == numToCheck)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(numToCheck + "為質數\n");
                    Console.ForegroundColor = originalColor;
                }
                if (i != numToCheck && numToCheck != 2)
                    Console.WriteLine(numToCheck + "不為質數\n");
            }
        }
    }
}
