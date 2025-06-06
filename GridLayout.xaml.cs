namespace HuertasLAYOUT;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

   

    private void IrAStack_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackLayout());
    }
}