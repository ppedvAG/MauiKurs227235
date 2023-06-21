using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.MVVM.Model
{
    public class PKW
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public DateTime Baujahr { get; set; }


        public override string ToString()
        {
            return $"{Hersteller} ({MaxGeschwindigkeit}km/h), {Baujahr.Year}";
        }


        public static ObservableCollection<PKW> PkwListe { get; set; } = new ObservableCollection<PKW>()
        {
            new PKW {Hersteller = "BMW", MaxGeschwindigkeit=250, Baujahr = new DateTime(2002, 1, 1)}
        };
    }
}
