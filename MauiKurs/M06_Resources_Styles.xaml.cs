namespace MauiKurs;

public partial class Resources_Styles : ContentPage
{
	public Resources_Styles()
	{
		InitializeComponent();
	}

    private void Btn_Change_Clicked(object sender, EventArgs e)
    {
        // Codeseitiger Zugriff auf Ressource
        Sly_Main.Resources["Primary"] = new Color(11, 123, 234);
    }
}