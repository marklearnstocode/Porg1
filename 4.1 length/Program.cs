namespace _4._1_length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = ("Hej Alexander - er du klar til fredagsbaren senere HVA?");
            int teststring1 = testString.IndexOf('k', 25);
            Console.WriteLine(teststring1);
            Console.ReadLine();
        }
    }
}