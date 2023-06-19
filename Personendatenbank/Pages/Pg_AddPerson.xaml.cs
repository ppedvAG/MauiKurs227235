namespace Personendatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
	public Pg_AddPerson()
	{
		InitializeComponent();

        //Lab004
        Dpr_Birthdate.MaximumDate = DateTime.Now;
    }


    #region Lab03
    //private void Btn_ClickMe_Clicked(object sender, EventArgs e)
    //{
    //    Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;
    //}
    #endregion

    #region Lab04

    private async void Btn_Add_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert
            (
                $"{Ety_Name.Text} hinzufügen?",
                $"Soll diese Person gespeichert werden?\n{Ety_Name.Text} ({Pkr_Gender.SelectedItem})\nGeboren am {Dpr_Birthdate.Date.ToShortDateString()}\n{(Swt_Married.IsToggled ? "" : "Nicht ")}Verheiratet",
                "Ja",
                "Nein"
            );
    }

    private void Ety_Name_Completed(object sender, EventArgs e) => Dpr_Birthdate.Focus();

    private void Dpr_Birthdate_DateSelected(object sender, DateChangedEventArgs e) => Pkr_Gender.Focus();

    #endregion
}