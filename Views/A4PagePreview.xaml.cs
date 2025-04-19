using MarkdownEditor;
using System.Windows.Controls;

public partial class A4PagePreview : UserControl
{
    public A4PagePreview()
    {
        InitializeComponent();
        DataContextChanged += (s, e) =>
        {
            if (e.NewValue is MainWindow vm)
                PreviewBrowser.NavigateToString(vm.HtmlPreview);
        };
    }
}