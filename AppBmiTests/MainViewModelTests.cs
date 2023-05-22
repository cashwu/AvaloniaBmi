using AvaloniaAppBmi2;
using FluentAssertions;

namespace AppBmiTests;

public class MainViewModelTests
{
    [Fact]
    public void Test()
    {
        var mainViewModel = new MainViewModel
        {
            Height = 177,
            Weight = 90
        };

        mainViewModel.ShowResult.Execute(default);

        mainViewModel.Result.Should().Be("28.727");
    }
}