
class Program
{
    static void Main(string[] args)
    {
        new Opgave5_1version2().Run();

    }

    static void TryPlayWithList()
    {
        Console.WriteLine("Hello, World!");
        List<string> names = new List<string>
        {
            "Bruce",
            "Alfred",
            "Tim",
            "Richard"
        };

        names.ForEach(name => Console.WriteLine(name));

        names.Add("Peter");
        names.Add("Jens");

        Console.WriteLine("[" + string.Join(",", names) + "]");

        Console.WriteLine("Og dem med et e i eller som ender på d");
        names = names.FindAll(name => name.Contains('e') && name.EndsWith('d'));
        names.ForEach(name => Console.WriteLine(name));

        //Console.WriteLine(names.Aggregate((x, y) => x + ", " + y));
    }

    static void TryPlayWithRemove()
    {
        Console.WriteLine("Hello, World!");
        List<string> names = new List<string>
        {
            "Bruce",
            "Alfred",
            "Tim",
            "Richard"
        };

        names.ForEach(name => Console.WriteLine(name));

        names.Add("Peter");
        names.Add("Jens");

        Console.WriteLine("[" + string.Join(",", names) + "]");

        names.Remove("tim");

        Console.WriteLine("Her er Tim fjernet");
        Console.WriteLine("[" + string.Join(",", names) + "]");


        names.RemoveAt(1);
        Console.WriteLine("Her er streng med index 1 fjernet");
        Console.WriteLine("[" + string.Join(",", names) + "]");

        names.RemoveAll(name => name.Contains('e'));
        Console.WriteLine("Her er alle med et e i fjernet");
        Console.WriteLine("[" + string.Join(",", names) + "]");

        //Console.WriteLine(names.Aggregate((x, y) => x + ", " + y));
    }
}