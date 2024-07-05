using System.Diagnostics;

namespace JsonUtilities.Core;

public sealed partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        textBoxFinalJson.LinkClicked += OnLinkClicked;
        buttonBrowse.Click += OnButtonBroseClick;
    }

    private void OnLinkClicked(object? sender, LinkClickedEventArgs linkClickEvent)
    {
        if (linkClickEvent.LinkText != null)
        {
            Process.Start(new ProcessStartInfo(linkClickEvent.LinkText)
            {
                UseShellExecute = true
            });
        }
    }
    
    private void OnButtonBroseClick(object? sender, EventArgs clickEvent)
    {
        ExplorerFile.TryGetFileContent(OnFileContentReceived);
    }
    
    private void OnFileContentReceived(string jsonText)
    {
        if (string.IsNullOrEmpty(jsonText))
        {
            MessageBox.Show("Please select a valid .json file.");
            return;
        }

        jsonText = jsonText.Replace(textBoxNewValue.Text, textBoxOldValues.Text.Split(";"));
        jsonText = JsonMerger.Merge(jsonText, textBoxMergeJson.Text);

        textBoxFinalJson.Text = jsonText;
        textBoxFinalJson.SelectionStart = default;
        textBoxFinalJson.ScrollToCaret();
        Clipboard.SetText(jsonText);
    }
}