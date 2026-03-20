
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("PhamTranThanhVinh");
        Console.WriteLine("2415053122248");
        Console.WriteLine("225THLTC#04");
        var students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

        var group = students.GroupBy(s =>
            s.Score >= 8 ? "Gioi" :
            s.Score >= 6 ? "Kha" : "Trung binh"
        );

        foreach (var g in group)
        {
            Console.WriteLine(g.Key);
            foreach (var s in g)
                Console.WriteLine(" - " + s.Name);
        }
    }
}