namespace Personendatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
	public Pg_AddPerson()
	{
		InitializeComponent();

        //this.BindingContext = this.MeinePerson;

        //Lab004
        Dpr_Birthdate.MaximumDate = DateTime.Now;
    }

    //public Model.Person MeinePerson { get; set; } = new Model.Person();


    #region Lab03
    //private void Btn_ClickMe_Clicked(object sender, EventArgs e)
    //{
    //    Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;
    //}
    #endregion

    #region Lab04

    //private async void Btn_Add_Clicked(object sender, EventArgs e)
    //{
    //    await DisplayAlert
    //        (
    //            $"{Ety_Name.Text} hinzufügen?",
    //            $"Soll diese Person gespeichert werden?\n{Ety_Name.Text} ({Pkr_Gender.SelectedItem})\nGeboren am {Dpr_Birthdate.Date.ToShortDateString()}\n{(Swt_Married.IsToggled ? "" : "Nicht ")}Verheiratet",
    //            "Ja",
    //            "Nein"
    //        );
    //}

    private void Ety_Name_Completed(object sender, EventArgs e) => Dpr_Birthdate.Focus();

    private void Dpr_Birthdate_DateSelected(object sender, DateChangedEventArgs e) => Pkr_Gender.Focus();

    #endregion

    #region Lab07

    private async void Btn_Add_Clicked(object sender, EventArgs e)
    {
        Model.Person person = this.BindingContext as Model.Person;

        if (await DisplayAlert
            (
                $"{person.Name} hinzufügen?",
                $"Soll diese Person gespeichert werden?\n{person.Name} ({person.Gender})\nGeboren am {person.Birthdate.ToShortDateString()}\n{(person.IsMarried ? "" : "Nicht ")}Verheiratet",
                "Ja",
                "Nein"
            )
           )
        {
            this.BindingContext = new Model.Person();

        }
    }

    #endregion
}