using Sorting.basic_class.@static;
using Sorting.sorting.efficient;
using Sorting.sorting.specials;
using Sorting.sorting.simple;
public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        //int[] vet = ManagerFileReader.Arquivo10TXT();

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

        //ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);


        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado


        // --- Step 1: File Selection ---
        string[] fileOptions = { "10", "100", "1000", "10000", "100000", "1000000" };
        Console.WriteLine("Select the file to load:");
        for (int i = 0; i < fileOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {fileOptions[i]}-aleatorios.txt");
        }

        int fileChoice;
        while (!int.TryParse(Console.ReadLine(), out fileChoice) || fileChoice < 1 || fileChoice > fileOptions.Length)
        {
            Console.Write("Invalid input. Choose a valid option (1–6): ");
        }

        string fileName = $"inputs\\{fileOptions[fileChoice - 1]}-aleatorios.txt";
        // --- Step 2: Read File ---
        int[] array;
        try
        {
            string[] lines = File.ReadAllLines(fileName);
            array = Array.ConvertAll(lines, int.Parse);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return;
        }

        // --- Step 3: Sorting Algorithm Selection ---
        string[] sortOptions = {
            "Bubble Sort", "Insertion Sort", "Selection Sort", "Heap Sort", "Quick Sort",
            "Shell Sort", "Merge Sort", "Bucket Sort", "Counting Sort", "Radix Sort"
        };

        Console.WriteLine("\nSelect the sorting algorithm:");
        for (int i = 0; i < sortOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sortOptions[i]}");
        }

        int sortChoice;
        while (!int.TryParse(Console.ReadLine(), out sortChoice) || sortChoice < 1 || sortChoice > sortOptions.Length)
        {
            Console.Write("Invalid input. Choose a valid option (1–10): ");
        }

        // --- Step 4: Sort the Array ---
        SortingMeasurements measurements = new SortingMeasurements();
        switch (sortChoice)
        {
            case 1:
                BubbleSort.Sorting(array, measurements);
                break;
            case 2:
                InsertionSort.Sorting(array, measurements);
                break;
            case 3:
                SelectionSort.Sorting(array, measurements);
                break;
            case 4:
                HeapSort.Sorting(array, measurements);
                break;
            case 5:
                QuickSort.Sorting(array, measurements);
                break;
            case 6:
                ShellSort.Sorting(array, measurements);
                break;
            case 7:
                MergeSort.Sorting(array, measurements);
                break;
            case 8:
                BucketSort.Sorting(array, measurements);
                break;
            case 9:
                CountingSort.Sorting(array, measurements);
                break;
            case 10:
                RadixSort.Sorting(array, measurements);
                break;
            default:
                Console.WriteLine("This sorting algorithm is not yet implemented.");
                return;
        }
        // --- Step 5: Output ---
        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine();
        measurements.Print(sortOptions[sortChoice - 1]);



        // // Fila, Pilha e Lista em alocação estática
        // Fila f = new Fila(5);

        // f.Inserir(1);
        // f.Inserir(2);
        // f.Inserir(3);
        // f.Inserir(4);
        // f.Inserir(5);

        // f.Mostrar();

        // f.Inserir(6); // não consigo inserir pois a fila está cheia

        // f.Remover();

        // f.Mostrar();

        // f.Inserir(6);

        // f.Mostrar();

        // f.Remover();

        // f.Remover();

        // f.Remover();

        // f.Mostrar();

        // // Pilha
        // Pilha p = new Pilha(5);

        // p.Inserir(1);
        // p.Inserir(2);
        // p.Inserir(3);
        // p.Inserir(4);
        // p.Inserir(5);

        // p.Mostrar();
        // p.Inserir(6);

        // p.Remover();
        // p.Remover();

        // p.Mostrar();

    }
}