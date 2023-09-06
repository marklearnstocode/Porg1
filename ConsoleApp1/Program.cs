namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv dit navn: ");
            string name = Console.ReadLine();

            Console.Write("Skriv din alder: ");
            string age = Console.ReadLine();
            int intvalue = int.Parse(age);
            string message = "";

            if (intvalue >= 0 && intvalue <= 12)
            {
                message = "Du er et barn";
            }

            else if (intvalue >= 13 && intvalue <= 19)
            {

                message = "du er teenager";
            }
            else if (intvalue >= 20 && intvalue >= 25)
            {

                message = "du er studerende";
            }
            else if (intvalue >= 26 && intvalue >= 67)
            {

                message = "du er i arbejde";
            }
            else if (intvalue > 67)
            {

                message = "Du er en pensionist";
            }
            Console.WriteLine("Dit navn er " + name + ", og du er " + intvalue + " år gammel, hvilket betyder " + message);
        
        }
    }
}