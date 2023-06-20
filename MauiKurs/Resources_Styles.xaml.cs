namespace MauiKurs;

public partial class Resources_Styles : ContentPage
{
	public Resources_Styles()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Resources["Cyan200Accent"] = new Color(23, 34, 12);
    }
}