namespace HuertasLAYOUT;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private async void IrAAbsoluteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private void Boton1_Clicked(object sender, EventArgs e)
    {

    }

    private void Boton2_Clicked(object sender, EventArgs e)
    {

    }

    private void Boton3_Clicked(object sender, EventArgs e)
    {

    }

    private void Boton4_Clicked(object sender, EventArgs e)
    {

    }
}