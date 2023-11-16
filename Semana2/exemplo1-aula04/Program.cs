#region exemplo ReadLine
Console.WriteLine("Informe uma string:");
string? str = Console.ReadLine();
Console.WriteLine($"A string foi {str}");
#endregion

#region exemplos de List
List<List<string>> names = new List<List<string>>();
List<string> names2 = new List<string>();
names.Add(names2);
names[0].Add("Alice");
names[0].Add("Bob");
names.Add(new List<string>() {"Charlie", "David"});

foreach(List<string> list in names){
    foreach(string name in list){
        Console.WriteLine(name);
    }
}
#endregion