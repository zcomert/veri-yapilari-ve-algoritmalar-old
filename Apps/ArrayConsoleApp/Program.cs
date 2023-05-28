// overloading 
var names = new Array.Array<string>("Ahmet", "Mehmet", "Büşra", "Can","Burcu");

names.SetItem(1, "Melike");

foreach (var name in names)
{
    Console.WriteLine(name);
}

var numbers = new int[] { 1, 2, 3 };
numbers[0] = 10;


foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.ReadKey();
#region week-01
// array bir instance (örnektir)
var array = new Array.Array<string>();


array.Add("Ahmet");     // 0    4
array.Add("Mehmet");    // 1    4
array.Add("Can");       // 2    4
array.Add("Filiz");     // 3    4
array.Add("Furkan");    // 4    8

Console.WriteLine(array.GetItem(array.Find("Can"))); ;      

foreach (var item in array)
{
    Console.WriteLine(item);
}

// _InnerArray[0]

Console.WriteLine(array.Count);
Console.WriteLine(array.GetItem(3));   
Console.Read();
#endregion