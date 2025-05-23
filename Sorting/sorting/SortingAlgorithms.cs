public class SortingAlgorithms
{
    public static void Swap(int[] array, int i, int j, SortingMeasurements measurements)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        measurements.Assignments += 3;
        measurements.Swaps++;
    }
}