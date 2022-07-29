using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена2
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
        public double FuelSupply;//поменять на privat
        public List<string> PassengersNames;

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
        }//п1

        /*public Car()
        {

        }//п3*/
    }
    public static class Program
    {
        public static void Main()
        {
            /*{
                Car foo = new Car
                {
                    Producer = "Aston Martin",
                    FullName = "V12 Vanquish",
                    Color = Color.Grey,
                    Power = 460,
                    Consumption = 13,
                    VolumeTank = 78,
                    FuelSupply = 78,
                    PassengersNames = new List<string>(),
                };

                foo.SetFuelSupply(666);

                foo.PrintSelf();

            }//п2*/
        }
    }
}
