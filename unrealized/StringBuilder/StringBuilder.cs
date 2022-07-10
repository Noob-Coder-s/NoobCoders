using System;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //конструкторы строки
            {
                string s1 = "hello";
                string s2 = new string('a', 6); //aaaaaa
                //можно опустить string
                string ss2 = new('a', 6); //aaaaaa
                //string и String являются синонимами
                string s3 = new String(new char[] { 'h', 'e', 'l', 'l', 'o' }); //hello
                string s4 = new String(new char[] { 'h', 'e', 'l', 'l', 'o' }, 1, 3); // ell
            }

            //сравнение массивов и строк
            {
                int[] a = { 1, 2, 3 };
                int[] b = { 1, 2, 3 };
                if (a == b)
                    Console.WriteLine("Массивы можно сравнивать оператором сравнения");
                else
                    Console.WriteLine("Массивы нельзя сравнивать оператором сравнения, потому что оператором сравнения сравниваются ссылки, а не значения массивов");
                string s1 = "world";
                string s2 = "world";
                if (s1 == s2)
                    Console.WriteLine("Строки можно сравнивать оператором сравнения");
            }

            //методы строк. Нужно определить наиболее востребованные
            //особенно показать поиск по строке
            {

            }

            //строка - неизменяемый объект
            //все методы строк возвращают новую строку а не меняют исходную
            
            {
                string s = "hello world";
                //строка доступна на чтение
                Console.WriteLine(s[0]);
                //s[0] = 'H'; - ошибка: доступно только на чтение
                //как и массивы строки нельзя увеличить
            }

            //stringbuilder - решение проблем
            //синтаксис stringbuilder
            { 
                var sb = new StringBuilder();
                Console.WriteLine($"Длина: {sb.Length}");
                //по умолчанию выделяет 16 символов
                Console.WriteLine($"Емкость: {sb.Capacity}");
                //Создадим строку с capacity = n
                sb = new StringBuilder(10);
                Console.WriteLine($"Длина: {sb.Length}");
                Console.WriteLine($"Емкость: {sb.Capacity}");

                string s = "Hello world";
                //одинаково
                sb = new StringBuilder(s);
                sb = new StringBuilder("Hello world");
                Console.WriteLine($"Длина: {sb.Length}");
                Console.WriteLine($"Емкость: {sb.Capacity}");

                //Если мы знаем максимульную длину строки, то можем сразу ее указать
                sb = new StringBuilder(s, 11);
                Console.WriteLine($"Длина: {sb.Length}");
                Console.WriteLine($"Емкость: {sb.Capacity}");
            }

            //приведение примеров использования методов
            {

            }
        }
    }
}
