

var arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80 };

var index = Search.RecursiveBinarySearch.Search(arr, 0, arr.Length - 1, 80);

if (index != -1)
    Console.WriteLine($"Arr[{index}] = {arr[index]}");
else
    Console.WriteLine("Aranan eleman bulunamadı.");