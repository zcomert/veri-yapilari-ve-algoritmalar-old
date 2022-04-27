namespace Search
{
    public class BinarySearch
    {
        public static int Search<T>(T[] input, T key)
            where T : IComparable<T>
        {
            return search(input, 0, input.Length - 1, key);
        }

        private static int search<T>(T[] input, int i, int j, T key)
            where T : IComparable<T>
        {
            while (true)
            {
                if (i == j)
                {
                    if (input[i].Equals(key))
                    {
                        return i;
                    }
                    return -1;
                }

                int middle = (i + j) / 2;
                if (input[middle].Equals(key))
                {
                    return middle;
                }

                if (input[middle].CompareTo(key) >= 1)
                {
                    j = middle;
                    continue;
                }

                i = middle + 1;
            }
        }
    }
}