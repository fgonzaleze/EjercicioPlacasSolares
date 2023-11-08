using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace EjercicioPlacasSolares.Views;

public partial class Detalles : ContentPage
{
    public class Info
    {

        public string Nombre { get; set; }
        public string Datos { get; set; }

    }

    ObservableCollection<Info> Personas = new ObservableCollection<Info>();
    public ObservableCollection<Info> ColeccionPersonsas { get { return Personas; } }

    public Detalles()
    {
        InitializeComponent();
        Personas.Add(new Info() { Nombre = "Fernando Galiana", Datos = "Telefono 8871192" });
        Personas.Add(new Info() { Nombre = "Javier Gonzalez", Datos = "Telefono 111222333" });
        Personas.Add(new Info() { Nombre = "Isa Katharina", Datos = "Telefono 5721021" });
        Personas.Add(new Info() { Nombre = "Luisota", Datos = "Telefono 669221002" });
        Personas.Add(new Info() { Nombre = "Paco Pacome", Datos = "Telefono 35566654" });
        Personas.Add(new Info() { Nombre = "Carmen Reales", Datos = "Telefono 22345554" });
        Personas.Add(new Info() { Nombre = "Angel", Datos = "Telefono 9988212" });
        Personas.Add(new Info() { Nombre = "Pablo Romero", Datos = "Telefono 223345452" });
        Personas.Add(new Info() { Nombre = "Alessandro", Datos = "Telefono 2345543" });
        Personas.Add(new Info() { Nombre = "Marcos", Datos = "Telefono 34234423" });

        collectionView.ItemsSource = Personas;
    }


}
