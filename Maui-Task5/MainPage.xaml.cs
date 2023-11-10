namespace Maui_Task5;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void NextPageNavigation(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1(), true);
    }

}


