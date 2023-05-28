
using CollectionConsoleApp;

//cars
var list1 = new List<Customer>()
{
    new Customer(){Id = 1, FullName =" Ahmet Can"},
    new Customer(){Id = 2, FullName =" Mehmet Dağ"},
    new Customer(){Id = 3, FullName =" Fatma Güneş"},
    new Customer(){Id = 4, FullName =" Can Bulut"},
    new Customer(){Id = 5, FullName =" Canan Nehir"}
};

// home
var list2 = new List<Customer>()
{
     new Customer(){Id = 1, FullName =" Ahmet Can"},
     new Customer(){Id = 4, FullName =" Can Bulut"},
     new Customer(){Id = 6, FullName =" Melike Güneş"},
};

// home + cars

var result = new List<Customer>();

foreach (Customer customer in list1)
{
    if(list2.Select(c => c.Id).Contains(customer.Id))
    {
        result.Add(customer);
    }
}

result.ForEach(c => Console.WriteLine(c));


Console.ReadKey();























#region Group
void Group1()
{
    var g1 = new List<int>() { 10, 25, 20, 30, 4 };
    var g2 = new List<int>() { 15, 25, 3, 35, 4 };
    var g3 = new List<int>() { 10, 15, 20, 25, 40, 50, 4 };

    // Semih : Tekrar etmeyecek şekilde tüm elemanlar
    // dot per line
    // O(n) + O(n) + O(n) = c.O(n)
    g1
        .Union(g2)
        .Union(g3)
        .ToList();
    //.ForEach(n => Console.WriteLine(n));


    // Umut Çerkezoğlu: Ortak elemanlar 
    // O(n*n*n) = O(n3) 10 * 10 * 10
    g1
        .Intersect(g2)
        .Intersect(g3)
        .ToList();
    //.ForEach(n => Console.WriteLine(n));

    g1
        .Except(g2)
        .ToList()
        .ForEach(n => Console.WriteLine(n));


    //var arr = new char[] { 'a', 'h', 'm', 'e', 't' };
    var list = "ahmet".ToList();

    foreach (var item in "parlak")
    {
        list.Add(item);
        Console.WriteLine($"{item,-4} {list.Count,-4} " +
            $"{list.Capacity,-4}");
    }

    var result = new List<char>();

    foreach (var item in list)
    {
        // item : a, h, m, e, t
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }

    result.ForEach(c => Console.Write(c));


    // 
    //  "meltem"
    //  char[] = {'m','e','l','t','e','m'}

    var list2 = "meltem".ToList();

    var hashset = new HashSet<char>(list2);

    // dot per line
    hashset
        .ToList()
        .ForEach(c => Console.Write(c));
}
#endregion