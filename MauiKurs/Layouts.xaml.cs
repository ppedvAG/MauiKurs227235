namespace MauiKurs;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();
	}

    private void Btn_Schieben_Clicked(object sender, EventArgs e)
    {
		Grid.SetColumn(Lbl_Orange, 0);
    }
}