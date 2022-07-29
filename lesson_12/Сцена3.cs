using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена3
{
    public enum Color
    {
        Black,
        White,
        Red,
        Grey,
    }
    public class Square
    {
        public double A;
        public double B;
        public double area;

        public Square(double a, double b)
        {
            Console.WriteLine("...Работа конструктора...");
            A = a;
            B = b;
            area = A * B;
        }//п3

        /*public Square()
        {
        }//п5*/

        /*public Square(double a, double b)
        {

            Console.WriteLine($"Перед работой констркутора A = {A} и B = {B}");
            A = a;
            B = b;
            area = A * B;
            Console.WriteLine($"В конце работы конструктора A = {A} и B = {B}");
        }//п7*/

    }
    public static class Program
    {
        public static void Main()
        {
            /*{
                var square = new Square(10, 15); //создание объекта и передача аргументов в конструктор

                var square2 = new Square(); // ошибка, конструктор по умолчанию больше не создаётся.

                Console.WriteLine($"S = {square.area}");
            }/п4*/

            /*{
                Square square = new(10, 15); // При сокращённой записи конструктор работает как обычно

                new Square(10, 15); //Переменной ссылки нет.

                Console.WriteLine($"S = {square.area}");
            }//п6*/

            /*{
                Square square = new(10, 15) {A = 3, B = 5};

                Console.WriteLine($"После работы конструктора и списка инициализаторов:\n" +
                                    $"A = {square.A}, B = {square.B}");
            }//п8*/
        }
    }
}
