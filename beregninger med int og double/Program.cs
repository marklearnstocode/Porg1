namespace beregninger_med_int_og_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indlæs startpunktets x1-koordinat: ");
            double intx1 = double.Parse(Console.ReadLine());

            Console.Write("Indlæs startpunktets y1-koordinat: ");
            string y1 = Console.ReadLine();
            double inty1 = double.Parse(y1);

            Console.Write("Indlæs startpunktets x2-koordinat: ");
            string x2 = Console.ReadLine();
            double intx2 = double.Parse(x2);

            Console.Write("Indlæs startpunktets y2-koordinat: ");
            string y2 = Console.ReadLine();
            double inty2 = double.Parse(y2);

            Console.WriteLine("Hældningen for linjestykket er " + (inty2 - inty1)/(intx2 - intx1));
        }
    }
}