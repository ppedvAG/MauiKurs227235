using System.Diagnostics;

namespace MauiKurs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage beinhaltet die jeweils angezeigte Seite. Zuweisungen hier definieren die Startpage der App.
        MainPage = new Bindings.Bindings();
	}

    //Override der CreateWindow() um Zugriff auf globale shared Lifecycle-Events zu haben (für OS-spezifische LC-Events siehe MauiProgram.cs)
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) => Debug.Print("SharedCreated");
        window.Stopped += (s, e) => { Debug.Print("OnStop"); Preferences.Set("onStop", "CIAO"); };

        return window;
    }
}
