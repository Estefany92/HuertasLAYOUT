namespace HuertasLAYOUT;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
        InitializeComponent();
	}

    private void BotonIrAFlex_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutPage());
    }
}