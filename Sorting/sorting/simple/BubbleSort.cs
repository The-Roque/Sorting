namespace Sorting.sorting.simple
{
    public static class BubbleSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            int n = array.Length;
            measurements.Assignments++;

            for (int i = 0; i < n - 1; i++)
            {
                measurements.Assignments++;
                for (int j = 0; j < n - i - 1; j++)
                {
                    measurements.Comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        SortingAlgorithms.Swap(array, j, j + 1, measurements);
                    }
                }
            }
            measurements.StopTimer();
            measurements.Print("Bubble Sort");
        }
    }
}
