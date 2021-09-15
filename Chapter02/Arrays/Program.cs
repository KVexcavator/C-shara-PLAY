using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names; // может ссылаться на любой массив строк
            // объявление размера массива
            string[] names = new string[4];
            // хранение элементов с индексами позиций
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            for(int i = 0; i < names.Length; i++ ){
                Console.WriteLine(names[i]);
            }
        }
    }
}
