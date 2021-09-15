using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //целое число без знака - положительное целое число, включая 0
            uint naturalNumber = 23;
            // целое число - положительное или отрицательное число включая 0
            int integerNubmer = -23;
            // float - число одинарной точности с плавающей запятой, 
            //F указаывает, что это литерал типа float
            float realNumber = 2.3F;
            // double - число двойной точности с плавающей запятой
            double anotherRealNumber = 2.3; //литерал типа double
            // три переменные которые хранят число 2 000 000
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            // проверить
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3){
                Console.WriteLine($"{a}+{b} equals 0.3");
            } else {
                Console.WriteLine($"{a}+{b} does NOT equals 0.3");// выведет
            }

            Console.WriteLine("Using decimals:");

            decimal c = 0.1M;//M обозначает литерал типа decimal
            decimal d = 0.2M;

            if (c + d == 0.3M){
                Console.WriteLine($"{c}+{d} equals 0.3");// выведет
            } else {
                Console.WriteLine($"{c}+{d} does NOT equals 0.3");
            }
        }
    }
}
