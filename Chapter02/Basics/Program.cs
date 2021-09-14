using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // обьявление некоторых неиспользуемых переаенных
            // с помощью типов в дополнительных сборках
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            // перебор сборок, на которые ссылается приложение
            foreach(var r in Assembly.GetEntryAssembly()
                .GetReferencedAssemblies())
            {
                //загрузка сборки для чтения данных
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // обьявление переменной для подсчета методов
                int methodCount = 0;
                //перебор всех типов в слорке
                foreach(var t in a.DefinedTypes)
                {
                    // добавление количества методов
                    methodCount += t.GetMethods().Count();
                    // вывод количества типов и их методов
                    Console.WriteLine(
                        "{0:N0} types with {1:N0} methods in {2} assembly.",
                        arg0: a.DefinedTypes.Count(),
                        arg1: methodCount,
                        arg2: r.Name
                    );
                }
            }
        }
    }
}

// налог с продаж должун быть добавлен к промежуточной сумме
 /* это
многострочный
комментарий */
// var totalPrice = subtotal + salesTax; это операнд
// {  это блок
//     Console.WriteLine("Hello World!");
// }
//Console.WriteLine("Temperature on {0:D} is {1} C.", DateTime.Today, 24.5);
        