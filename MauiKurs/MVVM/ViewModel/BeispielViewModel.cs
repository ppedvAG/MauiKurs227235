using MauiKurs.MVVM.Model;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKurs.MVVM.ViewModel
{
    public class BeispielViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


		private string neuerHersteller = String.Empty;

		public string NeuerHersteller
		{
			get { return neuerHersteller; }
			set { neuerHersteller = value; HinzufügenCmd.ChangeCanExecute(); }
		}

		private int neueMaxG;

		public int NeueMaxG
		{
			get { return neueMaxG; }
			set { neueMaxG = value; HinzufügenCmd.ChangeCanExecute(); }
		}

		private DateTime neuesBaujahr;

        public DateTime NeuesBaujahr
		{
			get { return neuesBaujahr; }
			set { neuesBaujahr = value; HinzufügenCmd.ChangeCanExecute(); }
		}

		public ObservableCollection<PKW> PkwListe 
		{ 
			get { return Model.PKW.PkwListe; }
			set { Model.PKW.PkwListe= value; }
		}

		public Command HinzufügenCmd { get; set; }
		public Command LöschenCmd { get; set; }

		public Command ItemSelectedCmd { get; set; }


		public BeispielViewModel()
		{
			HinzufügenCmd = new Command
				(
					() =>
					{
						Model.PKW neuerPKW = new PKW() { Hersteller = NeuerHersteller, MaxGeschwindigkeit = NeueMaxG, Baujahr = neuesBaujahr };

						PkwListe.Add(neuerPKW);

						NeuerHersteller = String.Empty;
						NeueMaxG = 0;
						NeuesBaujahr = new DateTime();

						InformView(nameof(NeuerHersteller));
						InformView(nameof(NeueMaxG));
						InformView(nameof(NeuesBaujahr));
					},
					() =>
					{
						return !NeuerHersteller.Equals(string.Empty) && NeueMaxG > 0 && NeuesBaujahr.Year > 1950;
					}
				);

			LöschenCmd = new Command
				(
					listView =>
					{
						PkwListe.Remove((listView as ListView).SelectedItem as PKW);
						(listView as ListView).ClearValue(ListView.SelectedItemProperty);
						LöschenCmd.ChangeCanExecute();
					},
					listView =>
					{
						return (listView as ListView).SelectedItem != null;
					}
				);

			ItemSelectedCmd = new Command(() => LöschenCmd.ChangeCanExecute());
		}

		private void InformView(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
	}
}
