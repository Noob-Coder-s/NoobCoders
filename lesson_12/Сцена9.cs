using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сцена9
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
            VolumeTank = volumeTank;
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

        /*public string Producer
        {
            get { return producer; }
        }/п37*/

        /*public string Producer
        {
            set { producer = value; }
        }п38*/

        /*public string Producer
        {
            set { producer = value; }
            private get { return producer; }
        }//п40*/

        /*private string Producer
        {
            set { producer = value; }
            public get { return producer; } // модификатор доступа аксессора должен быть более ограничивающим
        }//п41*/

        /*public string Producer //Получаем значение как обычно
        {
            set { producer = value; }
            private get { return producer; }
        }//п42


        public int Producer // Представим, что задаём и получаем производителя в виде ID
        {
            set
            {
                producer = value switch
                {
                    0 => "Aston Martin",
                    1 => "Hyundai",
                    2 => "АвтоВАЗ",
                    _ => "ERROR",
                }
    ;
            }

            private get
            {
                return producer switch
                {
                    "Aston Martin" => 0,
                    "Hyundai" => 1,
                    "АвтоВАЗ" => 2,
                    _ => -1
                }

            ;
            }
        }//п43*/

        /*  public ref string Po // убрать ref для лемонстрации
      {
          get
          {
              return ref producer;
          }
      }//п45*/

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

                foo.Producer = "Hyundai";
                Console.WriteLine(foo.Producer);

            }//п39

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

                foo.Producer = "Hyundai"; //это предположительно работало бы нормально,
                                          //компилятор видит, что передаётся string, а не int, и вызывает соответсвующее свойство

                Console.WriteLine(foo.Producer);//Но как понять что нужно вызвать тут? Вполне ожидается как string, так и int.

            }//п44*/


            /*static void bar(out string baz)
            {
                baz = "Hyundai";
            }

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

                bar(out foo.Producer);

                foo.PrintSelf();
            }//п46*/
        }
    }
        
}
