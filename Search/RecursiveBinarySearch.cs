namespace Search
{
    public class RecursiveBinarySearch
    {
        public static int Search<T>(T[] array, int first, int last, T key)
            where T : IComparable
        {
            int middle = (first + last) / 2;
            if (array[middle].Equals(key))
                return middle;
            else if (first >= last)
                return -1;
            else if (key.CompareTo(array[middle]) == -1)
                return Search(array, first, middle, key);   // Go left
            else
                return Search(array, middle + 1, last, key);    // Go right
        }
    }
}