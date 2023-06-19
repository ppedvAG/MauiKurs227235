using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using System.Diagnostics;

namespace MauiKurs;

public static class MauiProgram
{
    //Der MauiAppBuilder erstllt die MAUI-App und bietet die Möglichkeiten diverse Elemente zu registrieren.
    //Hier können z.B. Fonts, Singletons, OS-spezifische LC-Events uvm eingebunden werden.
    //Zudem dient dieses Objekt als erster gemeinsamer Code aller Betriebssysteme. Die OS-spezifischen Einstiegspunkte
    //(z.B. Plattforms/Android/MainApplication) verweisen alle auf diese Methode.
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //Android-spezifische LC-Events
#if ANDROID
        builder.ConfigureLifecycleEvents
        (events =>
        {
            events.AddAndroid(android => android
                .OnStart(activity => Debug.Print("AndroidOnStart"))
                .OnStop(activity => Debug.Print("AndroidOnStop"))
                );
        }
        );
#endif

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
