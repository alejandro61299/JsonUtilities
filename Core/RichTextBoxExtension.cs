namespace JsonUtilities.Core;

public static class RichTextBoxExtension
{
    public static void SetText(this RichTextBox textBox, string value)
    {
        textBox.Text = value;
    }
}