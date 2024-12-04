namespace hodina_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string zadecislo = "Zadej číslo";
            int numberint;
            Console.WriteLine(zadecislo);
            int.Parse("2");
            while (!int.TryParse(Console.ReadLine(), out numberint)) ;
            {
                Console.WriteLine("Neplatný vstup, zadejte celá čísla");
            }
        }
    }
}
