using Android.Content;
using Android.Runtime;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Spezifische Implementierung muss in gleichem Namespace wie gemeinsame Definition sein
//(vgl. M009_Plattformspezifika\DeviceOrientationService.cs)
namespace MauiKurs.Plattformspezifika
{
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation()
        {
            //Implementierung des Android-spezifischen Codes (wird nur für Android compiliert)
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
            bool isLandscape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;
            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}
