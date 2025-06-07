namespace HuertasLAYOUT;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private async void VolverAlGrid_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayout());
    }
}