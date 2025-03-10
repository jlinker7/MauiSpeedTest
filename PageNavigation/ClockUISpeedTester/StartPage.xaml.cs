namespace ClockUISpeedTester
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked | Before Navigation.PushAsync(new PinPage());");
            Navigation.PushAsync(new PinPage());
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked | After Navigation.PushAsync(new PinPage());");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked_1 | Before Navigation.PushAsync(new FlatPinPage());");
            Navigation.PushAsync(new FlatPinPage());
            System.Diagnostics.Debug.WriteLine($"========================================= {DateTime.Now.ToString("mm:ss.fff")} | {this} | Button_Clicked_1 | After Navigation.PushAsync(new FlatPinPage());");
        }
    }

}
