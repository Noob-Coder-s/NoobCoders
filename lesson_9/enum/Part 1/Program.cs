using System;

namespace Part1
{
    class Program
    {
        enum НазваниеПеречисления
        {
            //значения разделяются запятой и именнуются с заглавной буквы
            Значение1,
            Значение2,
            //их может быть сколько угодно
            Значение3
        }
        enum НазваниеПеречисления2 { значение1, значение2, значение3 } // Вариант записи

        enum Mood
        {
            Joy,        // = 0
            Sadness,    // = 1
            Fear,       // = 2
            Boredom,    // = 3
            Anxiety     // = 4
        }

        public static void Main()
        {
            var joy = Mood.Joy;
            Console.WriteLine(joy.ToString());

            //Mood jackMood = 3; // ошибка

            var tomMood = (Mood)3; //явное преобразование

            //Mood annaMood = Fear; 

            var khanMood = Mood.Sadness; // = 1

            var panMood = tomMood; // = Boredom

            Console.WriteLine($"panMood {panMood}, tomMood {tomMood}");

            //Перечисления значимый тип данных, после этого значение tomMood не измениться
            panMood = Mood.Fear;

            Console.WriteLine(tomMood);

            Console.WriteLine((int)khanMood);

            Console.WriteLine($"panMood {panMood}, tomMood {tomMood}");

            CheckStatuses();
        }

        static double GetPrice(string status)
        {
            switch (status)
            {
                case "studentSchool": return 80;
                    // не используем break так как, return всё равно не даст уйти дальше.
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

        private static void CheckStatuses()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Укажите свой статус");
                var userInput = Console.ReadLine();

                var isValidStatus = Enum.TryParse(userInput, true, out Status status);
                if (isValidStatus)
                {
                    var price = GetPrice(status);

                    Console.WriteLine($"Статус {status} - цена билета: {price}");
                }
                else
                {
                    Console.WriteLine("Неверный статус");
                }
            }
        }

        enum Status
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
            Programmer
        }

        static double GetPrice(Status sts)
        {
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

        // Игральные карты - достоинство и масть
        enum Rank
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

        class CardItem
        {
            public Rank Rank { get; set; }
            public Suit Suit { get; set; }
        }

        public void SampleCardUsage()
        {
            var firstCard = new CardItem
            {
                Rank = Rank.Queen,
                Suit = Suit.Spades
            };

            Console.WriteLine($"Карта имеет достоинство {firstCard.Rank} и масть {firstCard.Suit}");
        }
    }
}
