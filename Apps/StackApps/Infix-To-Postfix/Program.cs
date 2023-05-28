double x = 0;
double y = 0;
double u = 0;
double t = 0;
string a = "2/(4-0)";
string b = "";
var s1 = new Stack<char>();

var s2 = new Stack<double>();

for (int i = 0; i < a.Length; i++)
{
    if (char.IsNumber(a[i]))
    {

        b += a[i];
    }

    else
    {
        if (a[i] == '*' || a[i] == '-' || a[i] == '/' || a[i] == '+')
        {
            s1.Push(a[i]);
        }
    }

}

var n = s1.Count;
for (int i = 0; i < n; i++)
{
    b += s1.Pop();
}


for (int i = 0; i < b.Length; i++)
{
    if (char.IsNumber(b[i]))
    {
        s2.Push(double.Parse(b[i].ToString()));
    }
    else
    {

        if (b[i] == '+')
        {

            x = s2.Pop() + s2.Pop();
            s2.Push(x);
        }
        if (b[i] == '-')
        {

            u = s2.Pop() - s2.Pop();
            u = u * -1;
            s2.Push(u);
        }
        if (b[i] == '/')
        {

            t = s2.Pop() / s2.Pop();
            s2.Push(t);
        }
        if (b[i] == '*')
        {
            y = s2.Pop() * s2.Pop();
            s2.Push(y);

        }
    }

}
Console.WriteLine(s2.Pop());


