namespace JsonUtilities.Core;

public static class FileSafe
{
    public static string ReadAllText(string filePath)
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