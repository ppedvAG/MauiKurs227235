using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiKurs.Navi.FlyoutBsp;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FlyoutBsp : ContentPage
{
    public ListView ListView;

    public FlyoutBsp()
    {
        InitializeComponent();

        BindingContext = new FlyoutPage1FlyoutViewModel();
        ListView = MenuItemsListView;
    }

    private class FlyoutPage1FlyoutViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<FlyoutPage1FlyoutMenuItem> MenuItems { get; set; }

        public FlyoutPage1FlyoutViewModel()
        {
            MenuItems = new ObservableCollection<FlyoutPage1FlyoutMenuItem>(new[]
            {
                //Dieses ViewModel beinhaltet die Daten des Flyout-Menüs. Hier können die einzelnen Menü-Einträge definiert werden
                    new FlyoutPage1FlyoutMenuItem { Id = 0, Title = "MAIN", TargetType=typeof(Navi.NavPageBsp) },
                    new FlyoutPage1FlyoutMenuItem { Id = 1, Title = "Grundlagen", TargetType=typeof(Xaml_Grundlagen) },
                    new FlyoutPage1FlyoutMenuItem { Id = 2, Title = "Controls", TargetType=typeof(Controls) },
                    new FlyoutPage1FlyoutMenuItem { Id = 3, Title = "Layouts", TargetType=typeof(Layouts) },
                    new FlyoutPage1FlyoutMenuItem { Id = 4, Title = "Bindings", TargetType=typeof(Bindings.Bindings) },
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}