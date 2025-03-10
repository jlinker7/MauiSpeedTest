namespace ShellNavigationSpeedTest;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FlatPinPage : ContentPage
{
    public FlatPinPage()
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Before InitializeComponent");
        InitializeComponent();
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | After InitializeComponent");
    }

    protected override void OnAppearing()
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnAppearing | Start");
        base.OnAppearing();
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnAppearing | End");
    }

    protected override void OnDisappearing()
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnDisappearing | Start");
        base.OnDisappearing();
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnDisappearing | End");
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatedFrom | Start");
        base.OnNavigatedFrom(args);
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatedFrom | End");
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatedTo | Start");
        base.OnNavigatedTo(args);
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatedTo | End");
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatingFrom | Start");
        base.OnNavigatingFrom(args);
        System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | OnNavigatingFrom | End");
    }
}