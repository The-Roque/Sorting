namespace Sorting.sorting.specials
{
    public static class CountingSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                measurements.Comparisons++;
                if (array[i] > max)
                    max = array[i];
                measurements.Assignments++;
            }

            int[] count = new int[max + 1];
            measurements.Assignments += max + 1;

            foreach (var item in array)
            {
                count[item]++;
                measurements.Assignments++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i]-- > 0)
                {
                    array[index++] = i;
                    measurements.Assignments++;
                }
            }
            measurements.StopTimer();
            measurements.Print("Counting Sort");
        }
    }
}
