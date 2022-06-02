using System;

namespace Part_1
{
    class Program
    {
        static double GetPrice(int status)          //Пример 1
        {
            switch (status)
            {
                case 0: return 80; // не используем break так как, return всё равно не даст уйти дальше.
                case 1: return 90;
                case 2: return 60;
                case 3: return 50;
                case 4: return 0;
                case 5: return 70;
                case 6: return 75;
                case 7: return 60;
                case 8: return 75;


                default: return 100;

            }
        }


        static double GetPrice(string status)           //Пример 2
        {
            switch (status)
            {
                case "studentSchool": return 80; // не используем break так как, return всё равно не даст уйти дальше.
                case "universityStudent": return 90;
                case "pensioner": return 60;
                case "veteranLabor": return 50;
                case "veteranWar": return 0;
                case "family": return 70;
                case "firefighter": return 75;
                case "teacher": return 60;
                case "doctor": return 75;

                default: return 100;

            }
        }


        enum НазваниеПеречисления           // Пример 3
        {
            Значение1, //значения разделяются запятой и именнуются с заглавной буквы
            Значение2,
            Значение3 //их может быть сколько угодно
        }
        enum НазваниеПеречисления2 { значение1, значение2, значение3 } // Вариант записи


        enum Mood       //Пример 4+
        {
            Joy,        // = 0
            Sadness,    // = 1
            Fear,       // = 2
            Boredom,    // = 3
            Anxiety     // = 4
        }

        public static void Main()
        {
            {
                //Mood jackMood = 3; // ошибка

                Mood tomMood = (Mood)3; //явное преобразование

                //Mood annaMood = Fear; 

                Mood khanMood = Mood.Sadness; // = 1

                Mood panMood = tomMood; // = Boredom

                panMood = Mood.Fear;    //Перечисления значимый тип данных, после этого значение tomMood не измениться

                Console.WriteLine(tomMood);

                Console.WriteLine((int)khanMood);

                Console.WriteLine(panMood);

                return;

            } //Пример 4+


            {
                Status Bob;

                while (true)
                {
                    Console.WriteLine("Ты кто такой? ");
                    int statusInt = int.Parse(Console.ReadLine());

                    if (0 <= statusInt && statusInt < (int)Status.Last)
                    {
                        Bob = (Status)statusInt;

                        Console.WriteLine($"Bob - {Bob} - ticket price: {GetPrice(Bob)}");
                    }
                }
            }       //Пример 5++


        }


        enum Status //Пример 5++
        {
            StudentSchool,
            UniversityStud,
            Pensioner,
            VeteranLabor,
            VeteranWar,
            Family,
            Firefighter,
            Teacher,
            Doctor,
            Plumber,
            Militia,
            Programmer, // Новые значения добавляем перед Last
            Last, // используется как последний элемент
        }

        static double GetPrice(Status sts)          //пример 5++
        {   //Как и обычно, указываем тип переменной -- имя перечисления

            switch (sts)
            {
                case Status.StudentSchool: return 80;
                case Status.UniversityStud: return 90;
                case Status.Pensioner: return 60;
                case Status.VeteranLabor: return 50;
                case Status.VeteranWar: return 0;
                case Status.Family: return 70;
                case Status.Firefighter: return 75;
                case Status.Teacher: return 60;
                case Status.Doctor: return 75;
                default: return 100;
            }
        }


        enum Rank // Пример 6+ Карты
        {
            Rank_2,
            Rank_3,
            Rank_4,
            Rank_5,
            Rank_6,
            Rank_7,
            Rank_8,
            Rank_9,
            Rank_10,
            Jack,
            Queen,
            King,
            Ace,
        }
        enum Suit { Clubs, Diamonds, Hearts, Spades, }


        enum Move       // Пример 7
        {
            Forward,
            Backward,
            Stop,
            Left,
            Right,
            Reverse,
        }

        enum Material       //Пример 8
        {
            Wood,
            Steel,
            Glass,
            Cloth,
            Stone,
        }

    }
}
