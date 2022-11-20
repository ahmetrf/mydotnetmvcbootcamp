var list = new List<string>();
list.Add("Bilgisayar");
list.Add("Telefon");
list.Add("Table");

foreach(var a in list)
{
    Console.WriteLine(a);
}

list.ForEach(aaa => Console.WriteLine(aaa));

var aa = new List<object>
{
    1,
    "ahmet",
    "arif",
    28,
    {
        "ahmet"
    }
};

foreach (var i in aa) Console.WriteLine(i);

Console.ReadKey();