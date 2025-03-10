namespace ShellNavigationSpeedTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked | Before await Shell.Current.GoToAsync(\"///PinPage\");");
            await Shell.Current.GoToAsync("///PinPage");
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked | After await Shell.Current.GoToAsync(\"///PinPage\");");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked_1 | Before await Shell.Current.GoToAsync(\"///FlatPinPage\");");
            await Shell.Current.GoToAsync("///FlatPinPage");
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked_1 | After await Shell.Current.GoToAsync(\"///FlatPinPage\");");
        }
    }

}
