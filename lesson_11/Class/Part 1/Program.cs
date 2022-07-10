using System;
using System.Collections.Generic;

namespace Part_1
{
    /// Пример кода 1
    /// Автомобиль: Kia Rio
    /// Производитель: Kia
    /// Цвет: белый
    /// Мощность: 123 л.с
    /// Расход топлива: 6.4л./100км.
    /// Объем бака: 50л.
    /// Остаток топлива: 50л.

    enum Color
    {
        Черный,
        Белый,
        Красный
    }
    //есть снипет для создания заготовки класса
    /// Пример кода 2
    class Car
    {
        //переменные внутри класса называются полями класса
        //в качестве поля класса может быть переменная любого типа
        //у каждого поля есть свой модификатор доступа. Для этого урока мы указываем его как public, а в дальнейшем разберем
        public string producer;
        public string fullName;
        public Color color;
        public int power;
        public double consumption;
        public double volumeTank;
        public double fuelSupply;
    }

    class Program
    {
        ///Пример кода 5
        static void PrintCarInfo(Car c)
        {
            Console.WriteLine($"Автомобиль: {c.fullName}\n" +
                              $"Производитель: {c.producer}\n" +
                              $"Цвет: {c.color}\n" +
                              $"Мощность: {c.power}л.с\n" +
                              $"Расход топлива: {c.consumption}л./100км.\n" +
                              $"Объем бака: {c.volumeTank}л.\n" +
                              $"Остаток топлива: {c.fuelSupply}л.");
        }

        ///Пример кода 6
        static void ChangeCarColor(Car c, Color color)
        {
            c.color = color;
        }

        static void Main(string[] args)
        {
            ///Пример кода 3
            Car c = new Car();
            var c2 = new Car();
            Car c3 = new(); //валидный синтаксис, достаточно указать класс один раз
            //порядок неважен
            c.producer = "Kia";
            c.fullName = "Kia Rio";
            c.color = Color.Белый;
            c.power = 123;
            c.consumption = 6.4;
            c.volumeTank = 50;
            c.fuelSupply = c.volumeTank;

            //выведем характеристики автомобиля
            ///Пример кода 4
            Console.WriteLine($"Автомобиль: {c.fullName}\n" +
                              $"Производитель: {c.producer}\n" +
                              $"Цвет: {c.color}\n" +
                              $"Мощность: {c.power}л.с\n" +
                              $"Расход топлива: {c.consumption}л./100км.\n" +
                              $"Объем бака: {c.volumeTank}л.\n" +
                              $"Остаток топлива: {c.fuelSupply}л.");

            ChangeCarColor(c, Color.Красный);
            PrintCarInfo(c);
        }
    }
}
