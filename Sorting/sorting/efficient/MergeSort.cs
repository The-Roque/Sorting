namespace Sorting.sorting.efficient
{
    public static class MergeSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {
            measurements.Reset();
            measurements.StartTimer();
            MergeSortRecursive(array, 0, array.Length - 1, measurements);
            measurements.StopTimer();
            measurements.Print("Merge Sort");
        }

        private static void MergeSortRecursive(int[] array, int left, int right, SortingMeasurements measurements)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                measurements.Assignments++;

                MergeSortRecursive(array, left, mid, measurements);
                MergeSortRecursive(array, mid + 1, right, measurements);
                Merge(array, left, mid, right, measurements);
            }
        }
        private static void Merge(int[] array, int left, int mid, int right, SortingMeasurements measurements)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            measurements.Assignments += 2;

            int[] L = new int[n1];
            int[] R = new int[n2];
            measurements.Assignments += n1 + n2;

            for (int i = 0; i < n1; i++) L[i] = array[left + i];
            for (int j = 0; j < n2; j++) R[j] = array[mid + 1 + j];

            int ii = 0, jj = 0, k = left;
            measurements.Assignments += 3;

            while (ii < n1 && jj < n2)
            {
                measurements.Comparisons++;
                if (L[ii] <= R[jj])
                {
                    array[k++] = L[ii++];
                    measurements.Assignments++;
                }
                else
                {
                    array[k++] = R[jj++];
                    measurements.Assignments++;
                }
            }

            while (ii < n1) array[k++] = L[ii++];
            while (jj < n2) array[k++] = R[jj++];
            measurements.Assignments += (n1 - ii) + (n2 - jj);
        }
    }
}
