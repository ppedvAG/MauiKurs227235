using System.ComponentModel;

namespace MauiKurs.Bindings;

public partial class Bindings : ContentPage
{
	public Bindings()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Person", $"Name: {(Stl_DataBinding.BindingContext as Person).Name}\nAlter: {(Stl_DataBinding.BindingContext as Person).Alter}", "ok");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).Alter++;
        (Stl_DataBinding.BindingContext as Person).UpdateGui();
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).WichtigeTage.Remove((DateTime)LstV_Tage.SelectedItem);
    }
}