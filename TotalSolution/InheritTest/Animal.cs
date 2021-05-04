using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    //Access Modifier : public, protected, private
    class Animal
    {
        //특성->속성
        public int Age { get; set; }

        //기본 생성자
        public Animal() { this.Age = 0;}

        //액선->메서드
        public void Eat() { Console.WriteLine("먹습니다"); }
        public void Sleep() { Console.WriteLine("잡니다"); }
    }
}
