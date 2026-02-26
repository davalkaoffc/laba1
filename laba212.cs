var словник = new Dictionary<string, string[]>
{
    { "1", new[] { "A", "d" } },
    { "2", new[] { "C", "B" } }
};
string[] масив1 = словник["1"];
string[] масив2 = словник["2"];
foreach (var буква1 in масив1)
{
    foreach (var буква2 in масив2)
    {
        Console.Write(буква1 + буква2);
    }
    Console.Write(" ");
}
Console.WriteLine();
