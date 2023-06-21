namespace MauiKurs.Plattformspezifika;

public partial class Plattformspez : ContentPage
{
	public Plattformspez()
	{
		InitializeComponent();

		Lbl_Show.Text = new Plattformspezifika.DeviceOrientationService().GetOrientation().ToString();

		Pref.Text = Preferences.Get("Stop", "nothing");
	}
}