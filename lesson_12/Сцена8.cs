using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена8
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
                $"Остаток топлива: {FuelSupply}л.");
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

        public void SetFuelSupply(double fuelSupply)
        {
            if (fuelSupply < 0) FuelSupply = 0;
            else if (fuelSupply > VolumeTank) FuelSupply = VolumeTank;
            else FuelSupply = fuelSupply;
        }

        public double GetFuelSupply()
        {
            return FuelSupply;
        }//29

        /*public double FuelSupply //п30 в процессе расмотренния переименовать поля
        {
            //get { return fuelSupply; }//подобную запись тоже имеет смысл показать
            get
            {
                fuelSupply = 5;
                return fuelSupply;
            }//п31

            set
            {
                Console.WriteLine(value);
                value = 7;
                Console.WriteLine(++value);

            }//п32

            set
            {
                if (value < 0) fuelSupply = 0;
                else if (value > VolumeTank) fuelSupply = VolumeTank;
                else fuelSupply = value;
            }//п34      

        }*/
        /*public Car(string producer = "Unknown", string fullName = "Unknown", Color color = 0, int power = 0, double consumption = 0, double volumeTank = 0, double fuelSupply = 0, List<string>? passengersNames = null)
        {
            Producer = producer;
            FullName = fullName;
            Color = color;
            Power = power;
            Consumption = consumption;
            VolumeTank = volumeTank;
            FuelSupply = fuelSupply;//присваиваем значение свойтву, а не полю. Также, хоть параметр и имеет то же имя, что и свойство, но локальные переменные приоритетнее
            PassengersNames = passengersNames;
        }//п35*/
    }
    public static class Program
    {
        public static void Main()
        {
            /*{
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

                Console.WriteLine($"В баке осталось {foo.FuelSupply}");// Из-за м.д private не можем получить значение

                //Console.WriteLine($"В баке осталось {foo.GetFuelSupply()}");

            }//п28*/

            /*{
                Car foo = new Car();

                foo.FuelSupply = 10;
            }//п33 */


            /*{
                Car foo = new Car
                (
                    "Aston Martin",
                    "V12 Vanquish",
                    Color.Grey,
                    460,
                    13,
                    78,
                    -15, //значение вне диапазона, но благодаря тому, что конструктор вызывает свойство, будет назначено допустимое
                    new List<string>()
                );

                Console.WriteLine($"В баке осталось {foo.FuelSupply}");// обращаемся к свойству, а не полю
                foo.FuelSupply = 27;
                Console.WriteLine($"В баке осталось {foo.FuelSupply}");

            }//п34*/


        }


    }
}


