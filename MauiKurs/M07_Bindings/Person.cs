using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Bindings
{
    //Model-Klasse zur Verwendung im BindingContext
    //Das Interface INotifyPropertyChanged sorgt für ein neues Event, welches bei Aktivierung die GUI über eine Veränderung in diesem Objekt informiert
    internal class Person : INotifyPropertyChanged
    {
        //Eine Datenbindung kann nur an Properties durchgeführt werden (keine Felder)
        public string Name { get; set; }

        private int alter;
        public int Alter
        {
            get => alter;
            set
            {
                alter = value;
                //Das PropertyChanged-Event muss zu dem Zeitpunkt geworfen werden, zu dem die GUI über eine Veränderung informiert werden soll
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            }
        }

        //Durch das Interface geforderte Event
        public event PropertyChangedEventHandler PropertyChanged;

        //Properties vom Typ ObservableCollection informieren die GUI automatisch über Veränderungen (z.B. neuer Listeneintrag). Sie eignen sich besonders gut
        //für eine Bindung an ein ItemControl (z.B. Picker, ListView, CollectionView, ...)
        public ObservableCollection<DateTime> WichtigeDaten { get; set; }

        public Person()
        {
            WichtigeDaten = new ObservableCollection<DateTime>();

            //Erstellen von Bsp-Daten
            WichtigeDaten.Add(new DateTime(2002, 12, 3));
            WichtigeDaten.Add(new DateTime(2013, 1, 2));
        }

        //Alternativaufruf für PropertyChanged per Funktion
        public void UpdateGui() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));



    }
}