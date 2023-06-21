namespace MauiKurs.Navi;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Manuelle Routen-Registrierung
        Routing.RegisterRoute("navi/routeTarget", typeof(RouteTargetPage));
	}
}