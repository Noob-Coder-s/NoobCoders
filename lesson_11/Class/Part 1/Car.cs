class Car
{
    public string Producer;
    public string FullName;
    public Color Color;
    public int Power;
    public double Consumption;
    public double VolumeTank;
    public double FuelSupply;
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
}
