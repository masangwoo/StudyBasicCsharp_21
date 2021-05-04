﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(), new Dog()
            };

            List<Cat> cats = new List<Cat>()
            {
                new Cat(), new Cat()
            };

            foreach (Dog item in dogs)
            {
                item.Color = "흰색";
                item.Age = 10 ;
                item.Eat();
                item.Sleep();
                item.Bark();

                Console.WriteLine(item.Age+"  "+item.Color);
            }

            foreach (Cat item in cats)
            {
                item.Age = 5;
                item.Eat();
                item.Sleep();
                item.Meow();

                Console.WriteLine(item.Age);

            }

        }
    }
}
