
class Program
{
    static void Main()
    {
        Console.WriteLine("PhamTranThanhVinh");
        Console.WriteLine("2415053122248");
        Console.WriteLine("225THLTC#04");
        var nums = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var result = nums.Distinct();

        Console.WriteLine(string.Join(" ", result));
    }
}