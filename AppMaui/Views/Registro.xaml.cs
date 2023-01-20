namespace AppMaui.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}


    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        bool res = await DisplayAlert("Guardar Nuevo", "¿Agregar Nuevo?", "Si", "No");
    }
}
