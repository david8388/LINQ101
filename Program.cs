using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice {
    class Program {
        static void Main (string[] args) {
            LINQ1 ();
        }

        static void LINQ1 () {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 2, 7, 0 };
            var lowNums = from x in numbers
            where x < 5
            select x;

            foreach (var x in lowNums) {
                Console.WriteLine (x);
            }
        }
    }
}