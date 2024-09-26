using Avalonia.Controls;
using Avalonia.Input;

namespace IronIRC.Views;

public partial class ChatView : UserControl
{
    public ChatView()
    {
        InitializeComponent();
    }

    private void ChatInput_OnKeyUp(object? sender, KeyEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}