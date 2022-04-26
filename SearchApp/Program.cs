var arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

var index = Search.BinarySearch.Search<int>(arr, 20);

Console.WriteLine($"arr[{index}] = {arr[index]}");