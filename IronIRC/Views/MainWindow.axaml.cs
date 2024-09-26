using Avalonia.Controls;
using Avalonia.Interactivity;

namespace IronIRC.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AboutBtn_OnClick(object? sender, RoutedEventArgs e)
    {
        var dialog = new AboutWindow();
        dialog.ShowDialog(this);
    }
}