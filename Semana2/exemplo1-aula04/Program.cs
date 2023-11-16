// #region exemplo ReadLine
// Console.WriteLine("Informe uma string:");
// string? str = Console.ReadLine();
// Console.WriteLine($"A string foi {str}");
// #endregion

// #region exemplos de List
// List<List<string>> names = new List<List<string>>();
// List<string> names2 = new List<string>();
// names.Add(names2);
// names[0].Add("Alice");
// names[0].Add("Bob");
// names.Add(new List<string>() {"Charlie", "David"});

// foreach(List<string> list in names){
//     foreach(string name in list){
//         Console.WriteLine(name);
//     }
// }
// #endregion

#region exeplos de DateTime
DateTime now = DateTime.Now;
Console.WriteLine($"Now: {now}");

DateTime victorBorn = new DateTime(1998, 07, 13);
Console.WriteLine($"Victor born: {victorBorn.DayOfWeek}");
#endregion