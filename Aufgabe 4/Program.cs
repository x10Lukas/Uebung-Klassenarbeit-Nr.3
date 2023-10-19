class Program
{
    public class Geometrierechner
    {
        public double BerechneFlaeche(double radius)
        {
            return Math.PI * radius * radius;
        }
        public double BerechneFlaeche(double laenge, double breite)
        {
            return laenge * breite;
        }

        public double BerechneFlaeche(double basis, double hoehe, bool istDreieck)
        {
            if (istDreieck)
            {
                return 0.5 * basis * hoehe;
            }
            else
            {
                return 0;
            }
        }
    }
    static void Main()
    {
        Geometrierechner rechner = new Geometrierechner();
        Console.WriteLine("Fläche des Kreises: " + rechner.BerechneFlaeche(5));
        Console.WriteLine("Fläche des Rechtecks: " + rechner.BerechneFlaeche(4, 6));
        Console.WriteLine("Fläche des Dreiecks: " + rechner.BerechneFlaeche(4, 6, true));
    }
}