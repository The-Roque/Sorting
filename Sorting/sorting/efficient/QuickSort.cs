namespace Sorting.sorting.efficient
{
    public static class QuickSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            QuickSortRecursive(array, 0, array.Length - 1, measurements);
            measurements.StopTimer();
            measurements.Print("Quick Sort");
        }

        private static void QuickSortRecursive(int[] array, int low, int high, SortingMeasurements measurements)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high, measurements);
                QuickSortRecursive(array, low, pi - 1, measurements);
                QuickSortRecursive(array, pi + 1, high, measurements);
            }
        }

        private static int Partition(int[] array, int low, int high, SortingMeasurements measurements)
        {
            int pivot = array[high];
            int i = low - 1;
            measurements.Assignments += 2;

            for (int j = low; j < high; j++)
            {
                measurements.Comparisons++;
                if (array[j] < pivot)
                {
                    i++;
                    SortingAlgorithms.Swap(array, i, j, measurements);
                }
            }

            SortingAlgorithms.Swap(array, i + 1, high, measurements);
            return i + 1;
        }
    }
}
