using System;
using System.Windows.Input;

namespace AvaloniaAppBmi2;

public class CommandHandler : ICommand
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool> _canExecute;

    public CommandHandler(Action<object> execute)
        : this(execute, _ => true)
    {
    }

    public CommandHandler(Action<object> execute, Func<object, bool> canExecute)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        _execute.Invoke(parameter);
    }

    public event EventHandler CanExecuteChanged;
}