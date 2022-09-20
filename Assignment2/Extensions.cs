using System.Text.RegularExpressions;
namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri uri)
    {
        bool secure = uri.Scheme == Uri.UriSchemeHttps;
        return secure;
    }

    public static int WordCount(this string str)
    {
        string pattern = @"[a-zA-Z]+";
        Regex rg = new Regex(pattern);
        var m = rg.Matches(str);
        return m.Count;
    }
}
