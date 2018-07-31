using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4_8_課外作業_3_印出來_類似的_耶誕樹_要5層
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLayer = 5;    //宣告階層數
            int space = numOfLayer;

            string leaf = "*";

            
            while (numOfLayer > 0)
            {
                //以下區域敘述打空格(遞減)
                while( space > 0)
                {
                    Console.Write(" ");
                    space--;
                }
                Console.Write( leaf );
                Console.WriteLine();

                leaf += "**";
                numOfLayer--;
                space = numOfLayer;
            }
            Console.WriteLine();
            
        }
    }
}
