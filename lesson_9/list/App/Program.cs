using System;
using System.Collections.Generic;
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
            //Засекаем время, чтобы узнать, сколько займет копирование массива
            DateTime firstTime = DateTime.Now;
            foreach (var x in a)
                l.Add(x);
            //Выводим потраченное время
            Console.WriteLine($"Было потрачено {(DateTime.Now - firstTime).TotalSeconds} секунд на копирование массива");
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
            DateTime firstTime = DateTime.Now;
            l.Add(n);
            //Выводим потраченное время
            Console.WriteLine($"Было потрачено {(DateTime.Now - firstTime).TotalSeconds} секунд на добавление элемента в список");
        }

        public static void Main()
        {
            //Сравнение массивов
            {
                int[] a = { 1, 2, 3 };
                int[] b = { 1, 2, 3 };
                if (a == b)
                    Console.WriteLine("Массивы можно сравнивать оператором сравнения");
                else if (a.Equals(b))
                    Console.WriteLine("Для сравнения массивов нужно использовать специальный метод, который сравнивает каждый элемент");
                else
                    Console.WriteLine("Массивы нельзя сравнивать");
                return;
            }

            //синтаксис списка
            {
                //в <> мы указываем тип данных, которые хотим хранить в списке

                //Создадим список с capacity = 0
                List<int> l = new List<int>();
                //Создадим список с capacity = n
                int n = 10;
                l = new List<int>(n);
                Console.WriteLine($"Размер списка после создания: {l.Count}");
                Console.WriteLine($"Емкость списка после создания: {l.Capacity}");
                //создадим список - копию массива a(скопируются значения элементов массива, а не ссылка на массив)
                int[] a = new int[] { 1, 2, 3 };
                l = new List<int>(a);
                Console.WriteLine($"Размер списка после создания: {l.Count}");
                Console.WriteLine($"Емкость списка после создания: {l.Capacity}");
                //также можно использовать var
                var l2 = new List<int>();

                //можно работать точно как с массивом: обращаться по индексу и менять по индексу элементы, использовать foreach и тд
                l[0] = 666;
                Console.WriteLine(l[0]);
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

            //числа можно вводить через подчеркивание. Так они будут лучше читаться 
            int count = 100_000_000;
            int[] Array = new int[count];
            ///DateTime это такой класс, который хранит в себе дату и время. DateTime.Now возвращает нам текущее время и дату
            ///Которое мы можем сохранить в переменной. Если мы сохраним время до работы метода и время после работы метода 
            ///и вычтем одно из другого, то мы получим время, которое было затрачено на работу метода. TotalSeconds превращает эти данные в секунды
            ///Запускать только в Release сборке
            //создаем массив рандомных чисел
            {
                //Засекаем время, чтобы узнать, сколько займет создание массива
                DateTime firstTime = DateTime.Now;
                GenerateNumbers(Array);
                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {(DateTime.Now - firstTime).TotalSeconds} секунд на создание массива");
            }
            List<int> List = new List<int>(count);
            Console.WriteLine($"Размер списка после создания: {List.Count}");
            Console.WriteLine($"Емкость списка после создания: {List.Capacity}");
            //копируем данные массива в лист
            CopyArray(Array, List);

            //Добавляем рандомный элемент в массив
            {
                //Засекаем время, чтобы узнать, сколько займет добавление элемента
                DateTime firstTime = DateTime.Now;
                AddRandomElement(ref Array);
                //Выводим потраченное время
                Console.WriteLine($"Было потрачено {(DateTime.Now - firstTime).TotalSeconds} секунд на добавление элемента в массив");
            }

            //Добавляем элемент в список c таймером
            AddRandomElement(List);
            AddRandomElement(List); //1E-06 = 1 * 10^-6 = 0.000001

            //что будет если не выделить сразу подходящий объем памяти
            List<int> List2 = new List<int>();
            CopyArray(Array, List2);
            //Попробуйте с помощью дебагера посмотреть на то, как будут изменяться свойства count и capacity(находится в Raw View)
            //и постарайтесь сделать вывод, почему лучше изначально выделять необходимое количество памяти
        }
    }
}