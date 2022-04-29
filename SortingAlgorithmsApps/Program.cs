var arr = new double[] { 40.1, 50.2, 10.90, 30.3, 20.5 };

PrintArray(arr);
SortingAlgorithms.BubbleSort.Sort(arr);
PrintArray(arr);

Console.ReadKey();

static void PrintArray<T>(T[] arr)
{
    Console.WriteLine();
    foreach (var item in arr)
    {
        Console.Write($"{item,-5}");
    }
    Console.WriteLine();
}
