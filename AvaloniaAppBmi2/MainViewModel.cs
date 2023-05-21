using System;
using System.Windows.Input;

namespace AvaloniaAppBmi2;

public class MainViewModel : BaseViewModel
{
    private ICommand _showResult;
    private string _result;

    public ICommand ShowResult
    {
        get
        {
            return _showResult ??= new CommandHandler(_ =>
            {
                Console.WriteLine($"{Height}, {Weight}");

                Result = (Weight / Math.Pow(Height / 100, 2)).ToString("N");
            });
        }
    }

    public double Height { get; set; }

    public double Weight { get; set; }

    public string Result
    {
        get => _result;
        set => SetField(ref _result, value);
    }
}