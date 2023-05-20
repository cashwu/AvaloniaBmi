using System;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaAppBmi.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _result;

    public MainWindowViewModel()
    {
        ResultButtonCommand = ReactiveCommand.Create(ResultButtonCommandAction);
    }

    public ReactiveCommand<Unit, Unit> ResultButtonCommand { get; }

    private void ResultButtonCommandAction()
    {
        Result = (Weight / Math.Pow(Height / 100, 2)).ToString("N");

        Console.WriteLine($"Weight : {Weight}, Height : {Height}, Result : {Result}");
    }

    public double Height { get; set; }

    public double Weight { get; set; }

    public string Result
    {
        get => _result;
        set => this.RaiseAndSetIfChanged(ref _result, value);
    }
}