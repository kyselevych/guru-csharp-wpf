﻿using System.Windows;
using System.Windows.Controls;

namespace GuruCSharp.Pages;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    private void Loop_OnClick(object sender, RoutedEventArgs e)
    {
        SetPage(new SectionPage());
    }

    private void SetPage(object page)
    {
        var window = (MainWindow)Window.GetWindow(this);
        window.Main.Content = page;
    }
}