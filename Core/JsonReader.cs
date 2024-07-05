namespace JsonUtilities.Core;

public static class JsonReader
{
    public static bool Read(string filePath, out string value)
    {
        value = string.Empty;

        if (!Path.GetExtension(filePath).Equals(".json"))
        {
            return false;
        }

        value = FileSafe.ReadAllText(filePath);

        return value != string.Empty;
    }
}