using System.ComponentModel;

namespace MauiKurs.Bindings;

public partial class Bindings : ContentPage
{
    public Bindings()
    {
        InitializeComponent();
    }

    //EventHandler zur Anzeige des BindingContext-Objekts des StackLayouts
    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;

        await DisplayAlert("PERSON", $"{person.Name} {person.Alter}", "ok");
    }

    //EventHandler zur Manipulation des BindingContext-Objekts des StackLayouts
    private void Btn_Altern_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;

        person.Alter++;
    }

    //EventHandler zum Hinzufügen eines neuen Elements zur von dem ListView verwendeten Liste (vgl. Person.cs)
    private void Btn_Add_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;
        person.WichtigeDaten.Add(new DateTime(1999, 2, 23));
    }

    //EventHandler zum Löschen eines Elements aus der Liste (vgl. Person.cs)
    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        if (LstV_Personen.SelectedItem != null)
        {
            Person person = Sly_DataBinding.BindingContext as Person;

            person.WichtigeDaten.Remove((DateTime)LstV_Personen.SelectedItem);
        }
    }


}
