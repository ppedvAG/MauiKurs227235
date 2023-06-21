using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Plattformspezifika
{
    //Partielle gemeinsame Klassendefinition
    //Implementierung findet Plattformspezifisch in den jeweiligen Plattform-Ordnern statt
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation();
    }

    public enum DeviceOrientation
    {
        Undefined,
        Landscape,
        Portrait
    }
}
