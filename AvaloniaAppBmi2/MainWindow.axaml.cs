using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaAppBmi2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ResultClick(object? sender, RoutedEventArgs e)
    {
        double.TryParse(TxtHeight.Text, out var height);
        double.TryParse(TxtWeight.Text, out var weight);

        TxtResult.Text = (weight / Math.Pow(height / 100, 2)).ToString("N");
    }
}