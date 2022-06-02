using System;

namespace Part_2
{
    class Program
    {
        enum WeaponType //Пример 9+
        {
            Sword,
            Club,
            Axe,
            Bow,
        }
        enum WeaponType2
        {
            Sword, //= 0
            Club, //= 1
            Axe, //= 2
            Bow = 50,
            Hammer, //=51
            Knives, //=52
            Staff = 2, //
            Greatsword = Club, // = 1
        } //Для примера 10+ и 11+ и 12

        public static void Main()
        {

            {

                string[] Description = { "острый", "тяжёлый", "угрожающий", "точный" };
                for (WeaponType i = (int)0; i <= WeaponType.Bow; i++)
                {
                    Console.WriteLine($"{i} - {Description[(int)i]}");

                }
                return;
            }//Пример 9+

            {
                Console.WriteLine((WeaponType2)2);

                string[] Description = { "острый", "тяжёлый", "угрожающий", "точный" };
                for (WeaponType2 i = (int)0; i <= WeaponType2.Bow; i++)
                {
                    Console.WriteLine($"{i} - {Description[(int)i]}");

                }
                return;
            }//Пример 10+

            {
                int[] value = (int[])Enum.GetValues(typeof(WeaponType2));

                foreach (int i in value)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("^^^Вывод числовых значений^^^");

                string[] names = Enum.GetNames(typeof(WeaponType2));
                foreach (string i in names)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("^^^Вывод символьных значений^^^");
                return;
            }//Пример 11+

            {
                int[] value = (int[])Enum.GetValues(typeof(WeaponType2));
                string[] names = Enum.GetNames(typeof(WeaponType2));
                for (int i = 0; i < value.Length; i++)
                {
                    Console.WriteLine($"{names[i]} - {value[i]}");
                }
                return;

            }// Пример 12
        }

    }
}
