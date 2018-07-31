using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace m4_課外作業_產生一個從1到100共100個整數範圍的任意一個整數_要使用者猜出來
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            int secretNum = new Random().Next(100) + 1;     
            int maxNum = 100, minNum = 1;

            Console.WriteLine("\n從" + minNum +"到" + maxNum + "共" + (maxNum - minNum +1) + 
                "個整數範圍的任意一個整數為: " + secretNum + " (答案)\n");


            while (true)
            {

                START:
                int guessNum;
                string keyIn;
                Console.Write("請輸入猜測數字(1~100):");
                keyIn = Console.ReadLine();
                bool integerOrNot = int.TryParse(keyIn, out guessNum);
                
                if (guessNum < 0 || guessNum > 100 || integerOrNot == false)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("===輸入數字不合範圍，請重新輸入===\n");
                    Console.ForegroundColor = originalColor;
                    goto START;
                }

                if (guessNum == secretNum)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n=============YOU     WIN=============\n\n");
                    Console.ForegroundColor = originalColor;
                    break;
                }
                if (guessNum > secretNum && guessNum < maxNum) maxNum = guessNum;

                if (guessNum < secretNum && guessNum > minNum) minNum = guessNum;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(minNum + " < 猜測數字 < " + maxNum +"\t");
                Console.ForegroundColor = originalColor;
            }
        }
    }
}
