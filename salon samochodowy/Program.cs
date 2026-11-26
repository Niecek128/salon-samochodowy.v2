public class Auto
{
    public void Prowadź()
    {
        Auto Samochód = new (4999.99, "Yaris", "Toyota", 32980, 2022);
        Samochód.Prowadź(Console.WriteLine($"Przebieg: {Samochód.przebieg}"));

    }
}