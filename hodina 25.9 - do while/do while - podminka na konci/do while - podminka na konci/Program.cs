namespace do_while___podminka_na_konci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string zadecislo = "Zadej číslo";
            int numberint;

            
            do
            {
               
            }
            while (!int.TryParse(Console.ReadLine(), out numberint));

            Console.WriteLine(zadecislo);
            if (!int.TryParse(Console.ReadLine(), out numberint))
            {
                Console.WriteLine("Neplatný vstup, zadejte celá čísla");
            }
        }
    }
}