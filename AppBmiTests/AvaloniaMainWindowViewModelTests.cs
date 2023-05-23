using AvaloniaAppBmi.ViewModels;
using FluentAssertions;

namespace AppBmiTests;

public class AvaloniaMainWindowViewModelTests
{
    [Fact]
    public void Test()
    {
        var mainWindowViewModel = new MainWindowViewModel
        {
            Height = 177,
            Weight = 90
        };

        mainWindowViewModel.ResultButtonCommand
                           .Execute().Subscribe();
        
        mainWindowViewModel.Result.Should().Be("28.727");
    }
}