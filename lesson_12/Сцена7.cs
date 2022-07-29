using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена7
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
        public List<string>? PassengersNames;

        public void PrintSelf()
        {
            Console.WriteLine($"Автомобиль: {FullName}\n" +
                $"Производитель: {Producer}\n" +
                $"Цвет: {Color}\n" +
                $"Мощность: {Power}л.с\n" +
                $"Расход топлива: {Consumption}л./100км.\n" +
                $"Объем бака: {VolumeTank}л.\n" +
                $"Остаток топлива: {FuelSupply}л.\n");
        }
        public void SetFuelSupply(double fuelSupply)
        {
            if (fuelSupply < 0) FuelSupply = 0;
            else if (fuelSupply > VolumeTank) FuelSupply = VolumeTank;
            else FuelSupply = fuelSupply;
        }

        /*public Car(List<string>? passengersNames, string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply);
            PassengersNames = passengersNames;
        }//п19
            public Car( int passengerNumber,string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply);
            PassengersNames = new List<string>(4);
        }//п20

            public Car(string driverNames,string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
        {
            //Car(passengerNumber:4);//Увы, мы не можем вызвать конструктор обычным способом
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply);
            PassengersNames = new List<string>(4) {driverNames};
        }//п21*/
        

        public Car(string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            SetFuelSupply(fuelSupply);
            Console.WriteLine("Работа базового конструктора");

        }//п22
        public Car(List<string>? passengersNames, string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
            :this(producer, fullName, color, power, consumption, volumeTank, fuelSupply)
        {
            PassengersNames = passengersNames;
        }//п23
        public Car(int passengerNumber, string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0)
            :this(producer, fullName, color, power, consumption, volumeTank, fuelSupply)
        {
            
            PassengersNames = new List<string>(4) { "Kate"};
        }//п24

        public Car(string driverNames, string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0) 
            :this(producer, fullName, color, power, consumption, volumeTank, fuelSupply)
        {
            PassengersNames = new List<string>(1) { driverNames };
        }//п25

        public void PrintDriver()
        {
            Console.WriteLine(PassengersNames[0]);
        }//п26


    }
    public static class Program
    {
        public static void Main()
        {
            {
                Car foo = new(new List<string>() {"Vasya"}),
                    bar = new(10),
                    baz = new(driverNames:"Andrey");//пришлось использовать именнованный аргумент, так как возник неоднозначный вызов

                foo.PrintDriver();
                bar.PrintDriver();
                baz.PrintDriver();


            }//п27
        }
    }
}

       
