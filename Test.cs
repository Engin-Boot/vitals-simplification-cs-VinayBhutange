using System;
using System.Diagnostics;
using static Vital.VitalsChecker;

namespace Vital
{
    class Test
    {
        static void ExpectTrue(bool expression) {
            if (!expression) {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }
        static void ExpectFalse(bool expression) {
            if (expression) {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
        static int Main() {
            ExpectTrue(vitalsAreOk(100, 95, 60));
            Console.WriteLine("\nNew test");
            ExpectFalse(vitalsAreOk(40, 91, 92));
            Console.WriteLine("\nNew test");
            ExpectFalse(vitalsAreOk(160,120,100));
            Console.WriteLine("\nNew test");
            ExpectFalse(vitalsAreOk(90, 75, 40));
            Console.WriteLine("\nNew test");
            ExpectFalse(vitalsAreOk(50, 50, 10));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}