Console.WriteLine("PhamTranThanhVinh");
Console.WriteLine("2415053122248");
Console.WriteLine("225THLTC#04");
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
var result = numbers.Select(n => n * n);
Console.WriteLine(string.Join(" ", result));