using System.Diagnostics;

namespace JsonUtilities.Core;

public sealed partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        AllowDrop = true;
        DragEnter += OnDragEnter;
        DragDrop += OnDragDrop;
        textBoxFinalJson.LinkClicked += OnLinkClicked;
    }

    private void OnDragEnter(object? sender, DragEventArgs dragEvent)
    {
        if (dragEvent.Data == null)
        {
            return;
        }

        if (dragEvent.Data.GetDataPresent(DataFormats.FileDrop))
        {
            dragEvent.Effect = DragDropEffects.Copy;
        }
        else
        {
            dragEvent.Effect = DragDropEffects.None;
        }
    }

    private void OnDragDrop(object? sender, DragEventArgs dragEvent)
    {
        if (dragEvent.Data == null)
        {
            return;
        }

        if (dragEvent.Data.GetData(DataFormats.FileDrop) is not string[] files)
        {
            return;
        }

        if (files.Length <= 0)
        {
            return;
        }

        if (!JsonReader.Read(files[0], out string jsonText))
        {
            MessageBox.Show("Please drop a valid .json file.");
            return;
        }

        jsonText = jsonText.Replace(textBoxNewValue.Text, textBoxOldValues.Text.Split(";"));
        jsonText = JsonMerger.Merge(jsonText, textBoxMergeJson.Text);

        textBoxFinalJson.Text = jsonText;
        Clipboard.SetText(jsonText);
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
}