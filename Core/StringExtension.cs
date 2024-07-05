namespace JsonUtilities.Core;

public static class StringExtension
{
    public static string Replace(this string text, string newValue, params string[] oldValues)
    {
        if (string.IsNullOrEmpty(text))
        {
            return text;
        }

        if (string.IsNullOrEmpty(newValue))
        {
            return text;
        }

        foreach (string oldValue in oldValues)
        {
            if (string.IsNullOrEmpty(oldValue))
            {
                continue;
            }

            text = text.Replace(oldValue, newValue);
        }

        return text;
    }
}