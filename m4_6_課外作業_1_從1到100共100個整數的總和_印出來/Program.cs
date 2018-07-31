using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4_課外作業_從1到100共100個整數的總和_印出來
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            int limit = 100;
            while (i <= limit)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("\n 1~" + limit +"整數相加 = {0}\n", sum);
        }
    }
}
