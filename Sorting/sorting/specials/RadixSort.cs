namespace Sorting.sorting.specials
{
    public static class RadixSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();

            int max = array[0];
            foreach (var item in array)
            {
                measurements.Comparisons++;
                if (item > max) max = item;
                measurements.Assignments++;
            }

            for (int exp = 1; max / exp > 0; exp *= 10)
                CountSortByDigit(array, exp, measurements);

            measurements.StopTimer();
            measurements.Print("Radix Sort");
        }

        private static void CountSortByDigit(int[] array, int exp, SortingMeasurements measurements)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            measurements.Assignments += n + 10;

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
                measurements.Assignments++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                measurements.Assignments++;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int idx = (array[i] / exp) % 10;
                output[count[idx] - 1] = array[i];
                count[idx]--;
                measurements.Assignments += 2;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
                measurements.Assignments++;
            }
        }

    }
}
