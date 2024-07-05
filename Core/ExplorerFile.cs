namespace JsonUtilities.Core;

public static class ExplorerFile
{
    public  static void TryGetFileContent(Action<string> success)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        string filePath = openFileDialog.FileName;
        string fileContent = FileSafe.ReadAllText(filePath);
        success.Invoke(fileContent);
    }
}