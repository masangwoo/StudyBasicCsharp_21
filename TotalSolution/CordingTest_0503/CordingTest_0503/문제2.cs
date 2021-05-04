using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest_
{
    class 문제2
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("주소를 입력하세요 : ");
            string add = Console.ReadLine();

            Console.WriteLine($"반갑습니다. 저는 {add}에 살고 있는 {n}살 {name}입니다.");
        }
    }
}
