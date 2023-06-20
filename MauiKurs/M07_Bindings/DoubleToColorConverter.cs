using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Bindings
{
    //Converter müssen immer das Interface IValueConverter implementieren. Hier wird dann die Umwandlungslogik definiert
    internal class DoubleToColorConverter : IValueConverter
    {
        //Source->Target:
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Rückgabe einer Farbe, welche aus dem übertragenen Double-Wert generiert wird
            return new Color((byte)(double)value, System.Convert.ToByte(parameter), (byte)0);
        }

        //Target->Source
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Hier nicht nötig, deshalb nicht implementiert
            throw new NotImplementedException();
        }
    }
}
