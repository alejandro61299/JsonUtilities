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

        value = ReadFile(filePath);

        return value != string.Empty;
    }
    
    private static string ReadFile(string filePath)
    {
        try
        {
            return File.ReadAllText(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to the file is denied.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }

        return string.Empty;
    }
}