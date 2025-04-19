using Markdig;
using MarkdownEditor.Models;
using System.ComponentModel;

public class MainViewModel : INotifyPropertyChanged
{
    private string _markdownText = "";
    public string MarkdownText
    {
        get => _markdownText;
        set
        {
            _markdownText = value;
            OnPropertyChanged(nameof(MarkdownText));
            OnPropertyChanged(nameof(HtmlPreview));

        }
    }

    public string HtmlPreview => Markdig.Markdown.ToHtml(MarkdownText);

    public PageSettings PageSettings { get; set; } = new PageSettings();

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}