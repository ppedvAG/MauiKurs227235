namespace MauiKurs.Navi;

public partial class RoutingBsp : ContentPage
{
	public RoutingBsp()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Mittels des GoToAsync-Befehls können in der Shell angemeldete Routen angesteuert werden
        Shell.Current.GoToAsync("//grundlagen/layout");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //Wenn die Ziel-Page es erlaubt (vgl. RouteTargetPage.xaml.cs) können Objekte übertragen werden
        Shell.Current.GoToAsync($"//navi/routeTarget?RouteItem1={Ety_ItemToSend.Text}");
    }
}