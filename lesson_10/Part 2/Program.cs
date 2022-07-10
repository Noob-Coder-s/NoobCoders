using System;

namespace Part2
{
    enum WeaponType
    {
        Sword,
        Club,
        Axe,
        Bow,
    }

    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string[] description = { "острый", "тяжёлый", "угрожающий", "точный" };
            for (WeaponType i = 0; i <= WeaponType.Bow; i++)
            {
                Console.WriteLine($"{i} - {description[(int)i]}");
            }

            int[] value = (int[])Enum.GetValues(typeof(WeaponType2));

            Console.WriteLine("^^^Вывод значений (GetValues)^^^");
            foreach (int i in value)
            {
                Console.WriteLine(i);
            }

            string[] names = Enum.GetNames(typeof(WeaponType2));
            Console.WriteLine("^^^Вывод текстовых значений (GetNames)^^^");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            WeaponType2 test = WeaponType2.Club;
            WeaponType2 test2 = (WeaponType2)1;
            WeaponType2 test3 = (WeaponType2)2;
            WeaponType2 test4 = (WeaponType2)200;
            Console.WriteLine(test++);
        }
    }

    enum WeaponType2
    {
        Sword,
        Club,
        Axe = 3,
        Bow, // 4
        Bow1, // 5
        Bow2, // 6
        Bow3 = 70,
        Bow4, // 71
        Bow5,
        Bow6,
        Bow7 = 3,
        Bow8 = 3,
        Bow9 = 5,
    }
}
