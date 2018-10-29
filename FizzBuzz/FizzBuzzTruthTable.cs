using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzTruthTable
    {
        private static readonly Dictionary<(bool, bool), string> _fizzBuzzTruthTable
            = new Dictionary<(bool, bool), string>
            {
                [(false, false)] = null,
                [(false, true)] = "Buzz",
                [(true, false)] = "Fizz",
                [(true, true)] = "FizzBuzz"
            };

        public static void Run()
        {
            for (var i = 1; i <= 100; i++)
            {
                var fizzBuzz = _fizzBuzzTruthTable[(i % 3 == 0, i % 5 == 0)] ?? i.ToString();

                Console.WriteLine(fizzBuzz);
            }
        }
    }
}
