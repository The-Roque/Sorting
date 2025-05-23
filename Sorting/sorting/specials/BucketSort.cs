namespace Sorting.sorting.specials
{
    public class BucketSort
    {
        public static void Sorting(int[] array, SortingMeasurements measurements)
        {

            measurements.Reset(); measurements.StartTimer();
            measurements.StartTimer();

            if (array.Length == 0)
                return;

            // Find max value
            int maxValue = array[0];
            measurements.Assignments++;
            for (int i = 1; i < array.Length; i++)
            {
                measurements.Comparisons++;
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    measurements.Assignments++;
                }
            }

            // Create buckets
            int bucketCount = (int)Math.Sqrt(array.Length);
            List<int>[] buckets = new List<int>[bucketCount];
            measurements.Assignments++;

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
                measurements.Assignments++;
            }

            // Distribute elements
            foreach (int num in array)
            {
                measurements.Comparisons++;
                int bucketIndex = num * bucketCount / (maxValue + 1);
                buckets[bucketIndex].Add(num);
                measurements.Assignments++;
            }

            // Sort buckets and concatenate
            int index = 0;
            measurements.Assignments++;
            foreach (var bucket in buckets)
            {
                bucket.Sort(); // Uses internal sort (not tracked)
                foreach (int num in bucket)
                {
                    array[index++] = num;
                    measurements.Assignments++;
                }
            }

            measurements.StopTimer();
            measurements.Print("BucketSort");
        }

    }
}
