var list = new List<string>();
list.Add("Bilgisayar");
list.Add("Telefon");
list.Add("Table");

foreach(var a in list)
{
    Console.WriteLine(a);
}

list.ForEach(aaa => Console.WriteLine(aaa));

Console.ReadKey();