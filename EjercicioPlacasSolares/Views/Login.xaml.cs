namespace EjercicioPlacasSolares.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void btnClicker(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaTabbed());
    }
}