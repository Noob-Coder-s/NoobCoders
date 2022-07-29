using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена5
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
        }


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
        }
    }


    
    public static class Program
    {

        
        public static void Main()
        {
            {
                Car? foo = null;
                
                foo.PrintSelf();
            }//п13

            {
                Car? foo = null;
                if (foo == null)
                {
                    Console.WriteLine("555");
                }
                else
                {
                    foo.PrintSelf();
                }
            }//п14

            {
                Car? foo = null;
                
                if (foo == null)
                {
                    Console.WriteLine("555");
                }
                else
                {
                    TriplePrint(foo);
                }
                //TriplePrint(null);
                //TriplePrint(foo);// добавить после, чтобы показать, что среда ругается на передачу null
            }//п15
        }
        public static void TriplePrint(Car? baz)
        {
            baz.PrintSelf();
            baz.PrintSelf();
            baz.PrintSelf();
        }//п16

        


    }


   
}
