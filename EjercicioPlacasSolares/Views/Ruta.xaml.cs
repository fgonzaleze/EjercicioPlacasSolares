using System.Security.Cryptography.X509Certificates;

namespace EjercicioPlacasSolares.Views;

public partial class Ruta : ContentPage
{
	public Ruta()
	{
        
		InitializeComponent();
	}

    public async Task OpenMap()
    {
        var location = new Location(37.37425095858285, -5.9692928);
        var options = new MapLaunchOptions { Name = "IES Nervion" };
        
        await Map.Default.OpenAsync(location, options);


    }

    private async void btn(object sender, EventArgs e)
    {
        await OpenMap();
    }



}

