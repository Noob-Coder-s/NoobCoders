public static class Program
{
    public static void Main()
    {
        /// Пример кода 1
        /// Автомобиль: Kia Rio
        /// Производитель: Kia
        /// Цвет: белый
        /// Мощность: 123 л.с
        /// Расход топлива: 6.4л./100км.
        /// Объем бака: 50л.
        /// Остаток топлива: 50л.


        Car c = new Car();
        var c2 = new Car();
        Car c3 = new();

        //порядок неважен
        c.Producer = "Kia";
        c.FullName = "Kia Rio";
        c.Color = Color.White;
        c.Power = 123;
        c.Consumption = 6.4;
        c.VolumeTank = 50;
        c.FuelSupply = c.VolumeTank;

        c.PrintSelf();

        c3 = c;
        c3.VolumeTank = c3.VolumeTank + 1;
        c3.PrintSelf();
        c.PrintSelf();

        ChangeCarColor(c, Color.Red);
        PrintCarInfo(c);

        var cars = new List<Car>();
        cars.Add(c);
        cars.Add(c2);
        cars.Add(c3);

        Console.WriteLine("Количество машин в коллекции " + cars.Count);


        foreach (var car in cars)
        {
            car.PrintSelf();
        }


        var barCar = new Car();
        barCar.VolumeTank = 100;
        barCar.Color = Color.Red;
        barCar.Power = 10;

        var fooCar = new Car
        {
            VolumeTank = 100,
            Color = Color.Red,
            Power = 10,
        };

        PrintCarInfo(barCar);
        PrintCarInfo(fooCar);

        var carCreatedWithFactoryMethod = CreateCar("Lightning McQueen");
        PrintCarInfo(carCreatedWithFactoryMethod);

        var player1 = new Player
        {
            Name = "John",
            Balance = 100,
            Cards = new List<Card>()
            {
                new Card
                {
                    Rank = Rank.Two,
                    Suit = Suit.Hearts
                },
                new Card
                {
                    Rank = Rank.Queen,
                    Suit = Suit.Spades
                },
            }
        };
        var player2 = new Player
        {
            Name = "f",
        };

        player1.Cards.Add(new Card { Suit = Suit.Spades, Rank = Rank.Three });

        var r = player1.Cards[0].Rank;

        var allPlayers = new List<Player>
        {
            player1, player2
        };

        Console.WriteLine(allPlayers[0].Cards[0].Rank);
    }

    static Car CreateCar(string name)
    {
        var car = new Car
        {
            FullName = name,
            PassengersNames = new string[4]
        };

        return car;
    }

    static void PrintCarInfo(Car c)
    {
        Console.WriteLine($"Автомобиль: {c.FullName}\n" +
            $"Производитель: {c.Producer}\n" +
            $"Цвет: {c.Color}\n" +
            $"Мощность: {c.Power}л.с\n" +
            $"Расход топлива: {c.Consumption}л./100км.\n" +
            $"Объем бака: {c.VolumeTank}л.\n" +
            $"Остаток топлива: {c.FuelSupply}л.");
        Console.WriteLine();
    }

    static void ChangeCarColor(Car c, Color color)
    {
        c.Color = color;
    }

    // номинал
    enum Rank { Two, Three, Queen }
    // масть
    enum Suit { Spades, Hearts }

    // карта, имеющая номинал и масть
    class Card
    {
        public Rank Rank;
        public Suit Suit;
    }

    class Player
    {
        public List<Card> Cards = new();
        public decimal Balance;
        public string Name;
    }
}
