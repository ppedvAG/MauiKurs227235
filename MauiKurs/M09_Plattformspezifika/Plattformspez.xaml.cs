namespace MauiKurs.Plattformspezifika;

public partial class Plattformspez : ContentPage
{
    public Plattformspez()
    {
        InitializeComponent();

        //Mittels der DeviceInfo-Klasse kann C#-seitig zwischen unterschiedlichen Betriebssystemen ...
        if (DeviceInfo.Platform == DevicePlatform.Android)
            Lbl_DeviceInfo.Text = "C# - Android";
        else if (DeviceInfo.Platform == DevicePlatform.WinUI)
            Lbl_DeviceInfo.Text = "C# - WinUi";
        else
            Lbl_DeviceInfo.Text = "C# - Default";

        //... und Gerätetypen unterschieden werden
        if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
            Lbl_DeviceInfo.BackgroundColor = Colors.Green;
        else if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            Lbl_DeviceInfo.BackgroundColor = Colors.Blue;
        else
            Lbl_DeviceInfo.BackgroundColor = Colors.Red;

        //Mittels Compiler-Befehlen kann Code definiert werden, der nur für diese spezifischen OS compiliert werden 
#if ANDROID
        Lbl_Complilerbefehle.Text = "ANDROID";

#elif WINDOWS
        Lbl_Complilerbefehle.Text = "WINDOWS";
#endif

        //Aufruf von Betriebssystemspezifischem Code (vgl. Services.DeviceOrientationServices.cs, Platforms/Android/Services/DeviceOrientationServices.cs
        Lbl_Orientation.Text = new DeviceOrientationService().GetOrientation().ToString();
        //Zugriff auf abgespeicherten String über die Preferences-Klasse (vgl. App.xaml.cs)
        Lbl_Pref.Text = Preferences.Get("OnStop", "Nothing");

    }

    //Bsp für Anwendung einer Maui-Essentials-Klasse (Flashlight)
    //Benötigte Permissions müssen in den Manifesten definiert werden (vgl. Platforms/Android/AndroidManifest.xml)
    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            //Turn On
            await Flashlight.TurnOnAsync();
            //Turn Off
            await Flashlight.TurnOffAsync();
        }
        catch (FeatureNotSupportedException)
        {
            (sender as Button).Text = "No Flashlight";
        }
        catch (PermissionException)
        {
            (sender as Button).Text = "No Permission";
        }
        catch (Exception)
        {
            (sender as Button).Text = "Unknown Error";
        }

    }
}