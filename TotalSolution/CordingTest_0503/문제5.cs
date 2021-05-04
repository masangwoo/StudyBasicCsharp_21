using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_
{
    class 문제5
    {
        static void Main(string[] args)
        {
            int i=0
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");
            for (int i; i <= 100; i++)
            {
                if (i == 0) { Console.Write("짝! \t");}
                else if (i % 10 == 3) { Console.Write("짝! \t"); }
                else if (i % 10 == 6) { Console.Write("짝! \t"); }
                else if (i % 10 == 9) { Console.Write("짝! \t"); }
                else if (i / 10 == 3) { Console.Write("짝! \t"); }          
                else if (i / 10 == 6) { Console.Write("짝! \t"); }           
                else if (i / 10 == 9) { Console.Write("짝! \t"); }
                else { Console.Write(i + "\t"); }
            }

           
        }
    }
}
