namespace MobileApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        CounterBtn.Text = count == 1 ? $"Ai apasat o data" : $"Ai apasat de {count} ori";

     

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}



