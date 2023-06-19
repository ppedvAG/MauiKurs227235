namespace MauiKurs;

public partial class Xaml_Grundlagen : ContentPage
{
	public Xaml_Grundlagen()
	{
		InitializeComponent();

		Lbl_Beispiel.Text = "Passwort:";

	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
		bool result = await DisplayAlert("FRAGE", "Soll was passieren?", "Ja", "Nein");

		if (result)
		{
			Lbl_Beispiel.BackgroundColor = Colors.Green;

			(sender as Button).Text = "Wurde geklickt";
		}
    }
}

