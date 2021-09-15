using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Barmaley";

            Console.WriteLine($"{name} is {height} meters tall.");

            // int length1 = name.Length;  ошибочная запись
            int length2 = ((string)name).Length; 

            Console.WriteLine($"{name} is {length2} characters.");

            dynamic anotherName = "Barbambia";
            int length1 = anotherName.Length; // ошибки нет

            // локальные переменные
            var population = 66_000_000;
            var weight = 1.88;
            var price = 2.55M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;
            
            // значения по умолчанию
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
