namespace Sorting.sorting.simple
{
    public static class SelectionSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            int n = array.Length;
            measurements.Assignments++;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                measurements.Assignments++;

                for (int j = i + 1; j < n; j++)
                {
                    measurements.Comparisons++;
                    if (array[j] < array[minIdx])
                        minIdx = j;
                    measurements.Assignments++;
                }

                if (minIdx != i)
                    SortingAlgorithms.Swap(array, i, minIdx, measurements);
            }
            measurements.StopTimer();
            measurements.Print("Selection Sort");
        }
    }
}
