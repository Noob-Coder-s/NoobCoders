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
        public static void Main()
        {

            {

                string[] description = { "острый", "тяжёлый", "угрожающий", "точный" };
                for (WeaponType i = 0; i <= WeaponType.Bow; i++)
                {
                    Console.WriteLine($"{i} - {description[(int)i]}");

                }
            }//Пример 9+

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

                WeaponType2 test = WeaponType2.Club;
                WeaponType2 test2 = (WeaponType2)1;
                WeaponType2 test3 = (WeaponType2)2;
                WeaponType2 test4 = (WeaponType2)200;
                Console.WriteLine(test++);
                return;
            }//Пример 11+

        }
        enum WeaponType2 //Пример 9+
        {
            Sword,
            Club,
            Axe = 3,
            Bow, // 4
            Bow1, // 4
            Bow2, // 4
            Bow3 = 70, // 4
            Bow4, // 4
            Bow5, // 4
            Bow6, // 4
            Bow7 = 3, // 4
            Bow8 = 3, // 4
            Bow9 = 5, // 4
        }
    }
}
