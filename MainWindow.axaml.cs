using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace AvaloniaTestDrive;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnCalculate_OnClick(object? _, RoutedEventArgs e) => Calculate();

    private void Calculate()
    {
        if (double.TryParse(TxtCelsius.Text, out var celsius))
        {
            var fahrenheit = celsius * (9d / 5d) + 32;
            TxtFahrenheit.Text = fahrenheit.ToString("0.0");
        }
        else
        {
            TxtCelsius.Text = "0";
            TxtFahrenheit.Text = "0";
        }
    }

    private void TxtCelsius_OnTextChanged(object? sender, TextChangedEventArgs e) => Calculate();
}