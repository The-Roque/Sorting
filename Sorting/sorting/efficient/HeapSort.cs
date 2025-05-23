namespace Sorting.sorting.efficient
{
    public static class HeapSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            int n = array.Length;
            measurements.Assignments++;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i, measurements);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                SortingAlgorithms.Swap(array, 0, i, measurements);
                Heapify(array, i, 0, measurements);
            }
            measurements.StopTimer();
            measurements.Print("Heap Sort");
        }

        private static void Heapify(int[] array, int n, int i, SortingMeasurements measurements)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            measurements.Assignments += 3;

            if (left < n)
            {
                measurements.Comparisons++;
                if (array[left] > array[largest])
                    largest = left;
                measurements.Assignments++;
            }

            if (right < n)
            {
                measurements.Comparisons++;
                if (array[right] > array[largest])
                    largest = right;
                measurements.Assignments++;
            }

            if (largest != i)
            {
                SortingAlgorithms.Swap(array, i, largest, measurements);
                Heapify(array, n, largest, measurements);
            }
        }
    }
}
