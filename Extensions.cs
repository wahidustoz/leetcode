public static class Extensions
{
    public static void Print(this int[] sonlar)
        => Console.WriteLine($"[ {string.Join(", ", sonlar.Select(s => s.ToString()))} ]");
}