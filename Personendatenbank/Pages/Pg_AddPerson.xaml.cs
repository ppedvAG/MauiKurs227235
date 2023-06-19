namespace Personendatenbank.Pages;

public partial class Pg_AddPerson : ContentPage
{
	public Pg_AddPerson()
	{
		InitializeComponent();
	}


    #region Lab03
    private void Btn_ClickMe_Clicked(object sender, EventArgs e)
    {
        Lbl_Output.TextColor = (Lbl_Output.TextColor == Colors.Red) ? Colors.Green : Colors.Red;
    }
    #endregion
}