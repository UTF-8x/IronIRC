using System;
using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using IronIRC.ViewModels;

namespace IronIRC.Views;

public partial class AboutWindow : Window
{
    public AboutWindow()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        if (!File.Exists("ABOUT.md"))
            throw new ApplicationException("the ABOUT.md file doesn't exist, this should not happen");
         
        DataContext = new AboutWindowWM
        {
            Text = File.ReadAllText("ABOUT.md")
        };
    }
}