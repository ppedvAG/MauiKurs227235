namespace MauiKurs;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Lbl_Output.Text = Pkr_Affen.SelectedItem.ToString();
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Lbl_Output.Text = (sender as Entry).Text;
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Lbl_Stepper.Text = (sender as Stepper).Value.ToString();
    }
}