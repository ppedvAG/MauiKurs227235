namespace MauiKurs.Navi;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("navi/routeTarget", typeof(RouteTargetPage));
	}
}