namespace MauiKurs.Navi;

[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RouteTargetPage : ContentPage
{
	public string Item1 { set => Lbl_Main.Text = value; }

	public RouteTargetPage()
	{
		InitializeComponent();
	}
}