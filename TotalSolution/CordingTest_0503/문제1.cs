using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_
{
    class 문제1
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"원의 넓이는 {r * r * Math.PI}");
        }
    }
}
