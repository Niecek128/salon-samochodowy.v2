namespace salon_samochodowy
{
    public class Auto
    {
        private double Cena { get; set; }
        private string Model { get; set; }
        private string Marka { get; set; }
        private int Przebieg { get; set; }
        private int Rocznik { get; set; }
        public Auto(double cena, string model, string marka, int przebieg, int rocznik)
        {
            Cena = cena;
            Model = model;
            Marka = marka;
            Przebieg = przebieg;
            Rocznik = rocznik;
        }
    }
}
