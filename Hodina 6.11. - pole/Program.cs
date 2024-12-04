namespace Hodina_6._11.___pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Načtení pole od uživatele
            Console.WriteLine("Zadejte hodnoty pole oddělené mezerami:");
            int[] numbers = GetArrayFromInput();

            // Výpis původního pole
            Console.WriteLine("Původní pole:");
            PrintArray(numbers);

            // Najdeme index největšího prvku
            int maxIndex = FindMaxIndex(numbers);

            // Výměna největšího prvku s posledním prvkem
            SwapWithLast(numbers, maxIndex);

            // Výpis upraveného pole
            Console.WriteLine("\nPole po výměně:");
            PrintArray(numbers);
        }

        // Metoda pro vyhledání indexu největšího prvku
        static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        // Metoda pro výměnu prvku na zadaném indexu s posledním prvkem
        static void SwapWithLast(int[] array, int index)
        {
            int temp = array[index];
            array[index] = array[array.Length - 1];
            array[array.Length - 1] = temp;
        }

        // Metoda pro výpis pole
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Metoda pro získání pole od uživatele
        static int[] GetArrayFromInput()
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            int[] array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = int.Parse(parts[i]);
            }
            return array;
        }
    }
}
