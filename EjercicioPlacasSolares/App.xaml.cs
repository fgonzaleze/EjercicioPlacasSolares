namespace EjercicioPlacasSolares.Views;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new Login()); // Para el login

    }
}