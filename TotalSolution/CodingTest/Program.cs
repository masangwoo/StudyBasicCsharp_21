using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try//예외가 발생할 가능성이 있는 로직
            {
                Console.Write("값을 입력하세요(소수점) : ");
                string input = Console.ReadLine();
                float result = float.Parse(input);//예외발생
               
                //C# 4.0
                Console.WriteLine($"숫자값은 {result} 입니다.");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }





            /*Console.Write("숫자값을 입력하세요 : ");
            int ival = Convert.ToInt32(Console.ReadLine());
            Console.Write("값을 입력하세요 : ");
            string input = Console.ReadLine();

            //C# 4.0
            Console.WriteLine($"숫자값은 {ival} 입니다.");
            Console.WriteLine($"입력된 값은 {input} 입니다.");*/

            /*
             for (int i = 2; i < 10; i++)
             {
                 Console.WriteLine($"구구단 {i}단");
                 for (int j = 1; j < 10; j++)
                 {
                    Console.WriteLine($"{i}x{j}={i*j} ");
                 }
                 Console.WriteLine("==================");
             }
            */

            /* for (int i = 0; i < 10; i++)
             {

                 for (int j = 0; j < 10; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
        }*/
        }
    }
}
