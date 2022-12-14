Console.WriteLine(1.tostr());




public static class StringExtensions
{
    public static string tostr(this int s)
    {
        return "\"" + (s.ToString()) + "\"";
    }
}
