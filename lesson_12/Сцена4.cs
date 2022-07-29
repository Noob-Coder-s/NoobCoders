using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена4
{
    public enum Color
    {
        Black,
        White,
        Red,
        Grey,
    }

    public class Car
    {
        public string Producer;
        public string FullName;
        public Color Color;
        public int Power;
        public double Consumption;
        public double VolumeTank;
        private double FuelSupply;
        public List<string> PassengersNames;//на примере 11 изменить на nullable

        public void PrintSelf()
        {
            Console.WriteLine($"Автомобиль: {FullName}\n" +
                $"Производитель: {Producer}\n" +
                $"Цвет: {Color}\n" +
                $"Мощность: {Power}л.с\n" +
                $"Расход топлива: {Consumption}л./100км.\n" +
                $"Объем бака: {VolumeTank}л.\n" +
                $"Остаток топлива: {FuelSupply}л.");
        }
        public void SetFuelSupply(double fuelSupply)
        {
            if (fuelSupply < 0) FuelSupply = 0;
            else if (fuelSupply > VolumeTank) FuelSupply = VolumeTank;
            else FuelSupply = fuelSupply;
        }

        public Car() { }//Альтернативный вариант записи конструктора по умолчанию
        /*public Car(string producer, string fullName, Color color, int power, double consumption, double volumeTank, double fuelSupply, List<string> passengersNames)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply); //используем созданный нами метод
            PassengersNames = passengersNames;
        }//п9*/


        public Car(string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0, List<string>? passengersNames = null)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply);
            PassengersNames = passengersNames;
        }//п11
    }
    public static class Program
    {
        public static void Main()
        {
            {
                 Car foo = new Car
                 (
                     "Aston Martin",
                     "V12 Vanquish",
                     Color.Grey,
                     460,
                     13,
                     78,
                     666, //намеренно взяли значение значительно больше для проверки
                     new List<string>()
                 );//используем констркутор, а не список инициализации

                 foo.PrintSelf();
             }//п10


            {
                Car foo = new Car
                (
                    "Aston Martin",
                    "V12 Vanquish"                  
                );//указали только 2 аргумента, остальные будут иметь значение по умолчанию.
                //В принципе, могли и вовсе ничего не указывать

                foo.PrintSelf();
            }//п12


        }

    }
}
