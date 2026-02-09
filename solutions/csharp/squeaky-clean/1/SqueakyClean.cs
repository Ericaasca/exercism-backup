using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new(identifier);
        stringBuilder.Replace(" ", "_");
        stringBuilder.Replace("\0", "CTRL");
        for (int i = 0; i < stringBuilder.Length; i++)
        {
            if (stringBuilder[i] == Convert.ToChar("-"))
            {
                stringBuilder[i + 1] = Char.ToUpper(stringBuilder[i + 1]);
            }
        }
        var result = new string([.. stringBuilder.ToString().Where(c => Char.IsLetter(c) || c == '_')]);
        result = new string([.. result.ToString().Where(c => c <= '\u03b1'  || c >= '\u03cA')]);
        return result;
    }
}
