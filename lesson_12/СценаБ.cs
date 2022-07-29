using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СценаБ
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
        public double volumeTank;
        private double fuelSupply;
        public List<string>? PassengersNames;

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

        public Car(string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0, List<string>? passengersNames = null)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;//теперь свойство с init
            FuelSupply = fuelSupply;
            PassengersNames = passengersNames;
        }

        public double FuelSupply
        {
            get
            {
                return fuelSupply;
            }

            set
            {
                if (value < 0) fuelSupply = 0;
                else if (value > VolumeTank) fuelSupply = VolumeTank;
                else fuelSupply = value;
            }

        }

        public double VolumeTank
        {
            get { return volumeTank; }
            init
            {
                if (value < 0) volumeTank = 0;
                else volumeTank = value;
            }
        }

        public void ChangeColor(Color b)
        {
            Color = b;
        }
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
                    -15,
                    new List<string>()
                );

                foo.Color = Color.Grey;
                foo.ChangeColor(Color.Black);

                foo.PrintSelf();
                
            }

        }

    }
}

