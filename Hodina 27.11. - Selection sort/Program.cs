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

            // Seřazení pole pomocí Selection Sort
            SelectionSort(numbers);

            // Výpis seřazeného pole pomocí Selection Sort
            Console.WriteLine("\nSeřazené pole pomocí Selection Sort:");
            PrintArray(numbers);

            // Získání nového pole pro demonstraci Insert Sort
            Console.WriteLine("\nZadejte nové hodnoty pole pro Insert Sort:");
            int[] newNumbers = GetArrayFromInput();

            // Výpis původního pole pro Insert Sort
            Console.WriteLine("\nPůvodní pole:");
            PrintArray(newNumbers);

            // Seřazení pole pomocí Insert Sort
            InsertionSort(newNumbers);

            // Výpis seřazeného pole pomocí Insert Sort
            Console.WriteLine("\nSeřazené pole pomocí Insert Sort:");
            PrintArray(newNumbers);
        }

        // Metoda pro provedení Selection Sort
        static void SelectionSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                // Najdeme index největšího prvku v neseřazené části
                int maxIndex = FindMaxIndex(array, i);

                // Výměna největšího prvku s posledním prvkem v neseřazené části
                SwapWithLast(array, maxIndex, i);
            }
        }

        // Metoda pro vyhledání indexu největšího prvku v neseřazené části
        static int FindMaxIndex(int[] array, int endIndex)
        {
            int maxIndex = 0;
            for (int i = 1; i <= endIndex; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        // Metoda pro výměnu prvku na zadaném indexu s posledním prvkem v neseřazené části
        static void SwapWithLast(int[] array, int index, int endIndex)
        {
            int temp = array[index];
            array[index] = array[endIndex];
            array[endIndex] = temp;
        }

        // Metoda pro třídění pomocí Insertion Sort
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                InsertIntoSortedPart(array, i);
            }
        }

        // Metoda pro zařazení prvku do seřazené části
        static void InsertIntoSortedPart(int[] array, int index)
        {
            int current = array[index];
            int j = index - 1;

            // Posouvání větších prvků doprava
            while (j >= 0 && array[j] > current)
            {
                array[j + 1] = array[j];
                j--;
            }

            // Vložení aktuálního prvku na správné místo
            array[j + 1] = current;
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
