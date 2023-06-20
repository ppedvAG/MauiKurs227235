using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.Bindings
{
    public class Person : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Alter { get; set; }

        public ObservableCollection<DateTime> WichtigeTage { get; set; } = new ObservableCollection<DateTime>()
        {
            new DateTime(2003, 12, 2),
            DateTime.Now,
            new DateTime(2022, 1, 2)
        };

        public Person()
        {
            Name = "Anna";
            Alter = 35;
        }

        public void UpdateGui() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
