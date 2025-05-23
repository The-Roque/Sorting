namespace Sorting.sorting.efficient
{
    public static class ShellSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            int n = array.Length;
            measurements.Assignments++;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                measurements.Assignments++;
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;
                    measurements.Assignments += 2;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        measurements.Comparisons++;
                        array[j] = array[j - gap];
                        measurements.Assignments++;
                        j -= gap;
                    }

                    array[j] = temp;
                    measurements.Assignments++;
                }
            }
            measurements.StopTimer();
            measurements.Print("Shell Sort");
        }
    }
}
