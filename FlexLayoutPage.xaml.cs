namespace HuertasLAYOUT;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private void Regresar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}