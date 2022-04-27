namespace Search
{
    public class BinarySearch
    {

        public static int Search<T>(T[] input, T key) where T : IComparable<T>
        {
            return search(input, 0, input.Length - 1, key);
        }
        private static int search<T>(T[] input, int i, int j, T key) where T : IComparable<T>
        {
            while (true)
            {
                if (i == j)
                {
                    if (input[i].Equals(key))
                        return i;
                    return -1;
                }

                int mid = (i + j) / 2;

                if (input[mid].Equals(key))
                    return mid;

                if (input[mid].CompareTo(key) >= 1)
                {
                    j = mid;
                    continue;
                }
                i = mid + 1;
            }
        }
    }
}