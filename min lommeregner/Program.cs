namespace min_lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv første tal i regnestykket: ");
            int førsteTal = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast operatoren: ");
            string Op = Console.ReadLine();
            Console.WriteLine("Skriv dit andet tal i regnestykket: ");
            int andetTal = int.Parse(Console.ReadLine());

            Calculator calc = new Calculator();

            if (Op == "+")
            {
                Console.WriteLine("= " + calc.Add(førsteTal, andetTal));

            }
            else if (Op == "-")
            {
                Console.WriteLine("= " + calc.Substract(førsteTal, andetTal));
            }
            else if (Op == "/")
            {
                Console.WriteLine("= " + calc.Substract(førsteTal, andetTal));
            }
            else if (Op == "*")
            {
                Console.WriteLine("= " + calc.Substract(førsteTal, andetTal));
            }
            else
            {
            Console.WriteLine("Undskyld, men hvad mate?");
            }
            Console.ReadKey();
            // int x = calc.Add(4, 7);
            // Console.WriteLine(x);

            // int y = calc.Substract(2, 3);
            // Console.WriteLine(y);

            //double x1 = calc.Divide(2, 7);
            // Console.WriteLine(x1);

            //int y1 = calc.Multiply(2, 3);
            //Console.WriteLine(y1);
        }
    }
}