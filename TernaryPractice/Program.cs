using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TernaryPractice {
    internal class Program {
        static void Main(string[] args) {

            for (var i = 1; i <= 30; i++) {

                if (i % 3 == 0 && i % 5 == 0) {
                    System.Console.WriteLine($"{i} : FIZZBUZZ");
                } else if (i % 3 == 0) {
                    System.Console.WriteLine($"{i} : FIZZ");
                } else if (i % 5 == 0) {
                    System.Console.WriteLine($"{i} : BUZZ");
                } else {
                    System.Console.WriteLine($"{i}");
                }

            }
        }

    }
}
    

