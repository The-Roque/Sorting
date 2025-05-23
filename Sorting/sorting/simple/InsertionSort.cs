namespace Sorting.sorting.simple
{
    public static class InsertionSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            int n = array.Length;
            measurements.Assignments++;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;
                measurements.Assignments += 2;

                while (j >= 0)
                {
                    measurements.Comparisons++;
                    if (array[j] > key)
                    {
                        array[j + 1] = array[j];
                        measurements.Assignments++;
                        j--;
                    }
                    else break;
                }

                array[j + 1] = key;
                measurements.Assignments++;
            }
            measurements.StopTimer();
            measurements.Print("Insertion Sort");
        }
    }
}
