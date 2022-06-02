using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace App
{

    class Program
    {

        static void GenerateNumbers(int[] a)
        {
            //простой генератор рандомных чисел
            var r = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next();
        }

        static void CopyArray(int[] a, List<int> l)
        {
            foreach (var x in a)
                l.Add(x);
        }

        static void AddRandomElement(ref int[] a)
        {
            int[] res = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i];
            }
            var r = new Random();
            res[res.Length - 1] = r.Next();
            a = res;
        }

        static void AddRandomElement(List<int> l)
        {
            var r = new Random();
            var n = r.Next();
            //Засекаем время, чтобы узнать, сколько займет добавление элемента
            var sw = Stopwatch.StartNew();
            l.Add(n);
            //Выводим потраченное время
            Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на добавление очередного элемента в список");
        }

        public static void Main()
        {
            //числа можно вводить через подчеркивание. Так они будут лучше читаться 
            int count = 100_000_000;
            int[] array = new int[count];

            //создаем массив рандомных чисел
            {
                //Засекаем время, чтобы узнать, сколько займет создание массива
                var sw = Stopwatch.StartNew();
                GenerateNumbers(array);
                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на создание массива");
            }

            //синтаксис списка
            {
                //в <> мы указываем тип данных, которые хотим хранить в списке

                //Создадим список с capacity по умолчанию
                List<int> l = new List<int>();
                Console.WriteLine($"Размер списка по умолчанию после создания: {l.Count}");
                Console.WriteLine($"Емкость списка по умолчанию после создания: {l.Capacity}");

                //Создадим список с capacity = n
                int n = 10;
                l = new List<int>(n);

                Console.WriteLine($"Размер списка после создания: {l.Count}");
                Console.WriteLine($"Емкость списка после создания: {l.Capacity}");

                //создадим список - копию массива a (скопируются значения элементов массива, а не ссылка на массив)
                int[] a = new int[] { 1, 2, 3 };
                l = new List<int>(a);
                Console.WriteLine($"Размер списка после создания: {l.Count}");
                Console.WriteLine($"Емкость списка после создания: {l.Capacity}");

                //также можно использовать var
                var l2 = new List<int>();

                //можно работать точно как с массивом: обращаться по индексу и менять по индексу элементы, использовать foreach и тд
                l.Add(3);
                l.Add(4);
                l.Add(5);
                l[0] = 5;

                l.Add(5);

                foreach (var x in l)
                    Console.WriteLine(x);

                //есть метод, который может добавлять элементы в список
                l.Add(777);
                foreach (var x in l)
                    Console.WriteLine(x);

                //а также есть другие методы, полный список можно увидеть, если в Visual Studio поставить точку после переменной
                l.Clear();
                Console.WriteLine($"Размер списка после создания: {l.Count}");
                Console.WriteLine($"Емкость списка после создания: {l.Capacity}");
            }

            //копируем данные массива в лист

            //Добавляем рандомный элемент в массив
            {
                //Засекаем время, чтобы узнать, сколько займет добавление элемента
                var sw = Stopwatch.StartNew();
                AddRandomElement(ref array);
                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на добавление элемента в массив с копированием массива n+1");
            }

            // хотим добавить новый элемент
            List<int> list = new List<int>(array.Length + 1);

            {
                //Засекаем время, чтобы узнать, сколько займет копирование массива
                var sw = Stopwatch.StartNew();

                Console.WriteLine($"Размер нашего списка после создания: {list.Count}");
                Console.WriteLine($"Емкость нашего списка после создания: {list.Capacity}");

                CopyArray(array, list);
                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на копирование массива в лист");
            }

            //Добавляем элемент в список c таймером
            AddRandomElement(list);
            AddRandomElement(list);
            AddRandomElement(list); //1E-06 = 1 * 10^-6 = 0.000001

            {
                //что будет если не выделить сразу подходящий объем памяти
                List<int> List2 = new List<int>();
                var sw = Stopwatch.StartNew();
                CopyArray(array, List2);
                Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на копирование массива в лист");
            }
            //Попробуйте с помощью дебагера посмотреть на то, как будут изменяться свойства count и capacity(находится в Raw View)
            //и постарайтесь сделать вывод, почему лучше изначально выделять необходимое количество памяти

            var somelist = new List<int>(10);
            somelist[0] = 3; // ошибка: по такому индексу элемент ещё не был добавлен
        }
    }
}