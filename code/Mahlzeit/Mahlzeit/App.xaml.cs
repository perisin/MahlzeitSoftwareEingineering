namespace Mahlzeit;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Starte mit AppShell (Flyout-Navigation)
        MainPage = new Navigation.AppShell();
    }
}
