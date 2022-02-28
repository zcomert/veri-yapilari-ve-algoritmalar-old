using ValueAndReferenceTypes;

var p1 = new ValueAndReferenceTypes.ValueType
{ 
    X = 10,
    Y = 20
};

var p2 = p1;
p2.X = 30;

Console.WriteLine($"P1: {p1.X} {p1.Y}");
Console.WriteLine($"P2: {p2.X} {p2.Y}");