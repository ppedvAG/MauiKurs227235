namespace MauiKurs;

public partial class McSubscriberPage : ContentPage
{
	public McSubscriberPage()
    {
        //Einstellen der aktuellen Sprache -> Definiert zu ladende resx-Dateien
        M11_Loc.Strings.Culture = new System.Globalization.CultureInfo("de-DE");

        InitializeComponent();

        //Anmeldung am Messaging-Center -> Callback wird aufgerufen bei Empfang der Sendung
		MessagingCenter.Subscribe<Navi.NavPageBsp, string>(this, "nachricht", CallbackMethod);

	}

    //Callback-Methode für MessagingCenter
	public void CallbackMethod(Navi.NavPageBsp sender, string input)
    {
		Lbl_Main.Text = input;
    }
}