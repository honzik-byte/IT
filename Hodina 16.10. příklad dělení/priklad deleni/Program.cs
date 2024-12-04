namespace priklad_deleni                                //***Názvy začínají velkým písmenem (proměnné malým)
                                                        //***Rozdělte program na jednotlivé úlohy 
                                                        //***Ošetřit vstupy
{
    internal class Program
    {
        static void Main(string[] args)                 // ***Zobrazovací texty uložte na začátek do const string/int JMeno =" Obsah", konstanty se píšou na začátku s velkými písmeny
        {
            //deklarace proměnných
            string str;
            int num;

            //získání vstupu od uživatele
            Console.WriteLine("Zadejte řetězec (string):");
            str = Console.ReadLine();

            Console.WriteLine("Zadejte velé číslo (int): ");
            num = int.Parse(Console.ReadLine());

            //výměna hodnot mezi proměnnými
            string tempStr = str;
            str = num.ToString();
            num = int.Parse(tempStr);

            // Zobrazení vyměněných hodnot
            Console.WriteLine($"\nPo výměně: \nString: {str}\nInt: {num}");     //***Vysvětlete řádek

            // Dělení čísel 
            Console.Write("\nZadejte další číslo pro dělení: ");
            int divider = int.Parse(Console.ReadLine());

            // Vypis výsledku s popisem
            if (divider != 0)
            {
                double result = (double)num / divider;
                Console.WriteLine($"\nVýsledek dělení {num} / {divider} = {result}");
            }
            else
            {
                Console.WriteLine("\n Ahoj, neumíš matematiku, když chceš dělit nulou ty ňoumo. Doporučuju doučování u Holubové.");
            }
    }
}
}

