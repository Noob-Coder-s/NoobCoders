using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace App
{

    class Program
    {
        static readonly Random random = new();

        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //числа можно вводить через подчеркивание. Так они будут лучше читаться 
            var count = 100_000_000;
            var array = new int[count];

            //Засекаем время, чтобы узнать, сколько займет создание и заполнение массива
            var sw = Stopwatch.StartNew();
            array[1] = 1;
            array[count - 1] = count;

            Console.WriteLine($"Потрачено {sw.Elapsed} секунд на создание массива");

            for (int i = 0; i < array.Length; i++)
                array[i] = i;

            //Выводим потраченное время
            Console.WriteLine($"Потрачено {sw.Elapsed} секунд на заполнение массива");

            //синтаксис списка
            {
                //в <> мы указываем тип данных, которые хотим хранить в списке

                // создадим список с capacity по умолчанию
                var list = new List<int>();
                Console.WriteLine($"Размер списка по умолчанию после создания: {list.Count}");
                Console.WriteLine($"Емкость списка по умолчанию после создания: {list.Capacity}");

                // пересоздадим список с capacity = n
                int n = 10;
                list = new List<int>(n);

                Console.WriteLine($"Размер списка после создания: {list.Count}");
                Console.WriteLine($"Емкость списка после создания: {list.Capacity}");

                // есть метод, который может добавлять элементы в список
                list.Add(777);

                Console.WriteLine($"Размер списка после добавления одного элемента: {list.Count}");
                Console.WriteLine($"Емкость списка после добавления одного элемента: {list.Capacity}");

                // есть и такой вариант создания листа с инициализацией значениями
                var l3 = new List<int>
                {
                    777,
                    888
                };

                Console.WriteLine($"Размер списка после инициализации с двумя элементами: {l3.Count}");
                Console.WriteLine($"Емкость списка после инициализации с двумя элементами: {l3.Capacity}");

                //создадим список - копию массива a (скопируются значения элементов массива, а не ссылка на массив)
                int[] a = new int[] { 1, 2, 3 };
                list = new List<int>(a);
                Console.WriteLine($"Размер списка после создания на основе массива из 3 элементов: {list.Count}");
                Console.WriteLine($"Емкость списка после создания на основе массива из 3 элементов: {list.Capacity}");

                list.Add(123);
                Console.WriteLine($"Размер того же списка после добавления элемента: {list.Count}");
                Console.WriteLine($"Емкость списка после добавления элемента: {list.Capacity}");

                // можно работать точно как с массивом: обращаться по индексу и менять по индексу элементы,
                // использовать foreach и тд
                list[0] = 5;
                Console.WriteLine($"Первый элемент {list[0]}, последний: {list[list.Count - 1]}, количество: {list.Count}");

                list.Add(4);
                list.Add(5);
                list.Add(6);

                Console.WriteLine($"Выведем все элементы листа:");
                foreach (var item in list)
                    Console.WriteLine(item);

                //а также есть другие методы, полный список можно увидеть, если в Visual Studio поставить точку после переменной
                list.Clear();
                Console.WriteLine($"Размер списка после вызова метода Clear(): {list.Count}");
                Console.WriteLine($"Емкость списка после вызова метода Clear(): {list.Capacity}");
            }

            // добавляем новый элемент в массив с копированием исходного массива
            {
                //Засекаем время, чтобы узнать, сколько займет добавление элемента
                sw.Restart();

                var newArray = AppendRandomElement(array);
                Console.WriteLine($"Потрачено {sw.Elapsed} секунд на добавление элемента в массив с копированием массива n+1 размером {newArray.Length}");
            }

            List<int> newList;
            {
                // хотим добавить новый элемент
                newList = new List<int>(array.Length + 1);

                Console.WriteLine($"Размер нашего списка после создания: {newList.Count}");
                Console.WriteLine($"Емкость нашего списка после создания: {newList.Capacity}");

                //Засекаем время, чтобы узнать, сколько займет копирование массива
                sw.Restart();

                // наполняем лист элементами из массива
                CopyArray(array, newList);

                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {sw.Elapsed} секунд на копирование массива в лист с указанным Capacity");
            }

            // такое же копирование из массива в лист, но без указания Capacity при создании листа
            {
                var l = new List<int>();

                Console.WriteLine($"Размер нашего списка после создания: {l.Count}");
                Console.WriteLine($"Емкость нашего списка после создания: {l.Capacity}");

                //Засекаем время, чтобы узнать, сколько займет копирование массива
                sw.Restart();

                // наполняем лист элементами из массива
                CopyArray(array, l);

                //Выводим потраченное время
                Console.WriteLine($"Потрачено {sw.Elapsed} секунд на копирование массива в лист");
            }

            // добавляем элементы по одному в список c таймером
            {
                AddRandomElement(newList);
                AddRandomElement(newList);
                AddRandomElement(newList); //1E-06 = 1 * 10^-6 = 0.000001
            }

            // обращение к несуществующему элементу
            {
                var somelist = new List<int>(10);
                somelist[0] = 3; // ошибка: по такому индексу элемент ещё не был добавлен
                // вместо этого нужно сначала добавить элмемент методом Add()
            }
        }

        static void CopyArray(int[] a, List<int> l)
        {
            foreach (var x in a)
                l.Add(x);
        }

        static int[] AppendRandomElement(int[] a)
        {
            var res = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i];
            }
            res[res.Length - 1] = random.Next();
            return res;
        }

        static void AddRandomElement(List<int> l)
        {
            var n = random.Next();
            //Засекаем время, чтобы узнать, сколько займет добавление элемента
            var sw = Stopwatch.StartNew();
            l.Add(n);
            //Выводим потраченное время
            Console.WriteLine($"Потрачено {sw.Elapsed} секунд на добавление очередного элемента в список");
        }
    }
}