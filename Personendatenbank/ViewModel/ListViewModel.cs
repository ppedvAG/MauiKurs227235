using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.ViewModel
{
    internal class ListViewModel
    {
        public ObservableCollection<Model.Person> PersonList
        {
            get { return Model.Person.PersonList; }
        }

        public Command DeleteCmd { get; set; }

        public Command ItemSelectedCmd { get; set; } 

        public ListViewModel()
        {
            DeleteCmd = new Command
            (
                lv =>
                {
                    Model.Person.PersonList.Remove((lv as ListView).SelectedItem as Model.Person);
                    (lv as ListView).ClearValue(ListView.SelectedItemProperty);
                    DeleteCmd.ChangeCanExecute();
                },
                lv => (lv as ListView).SelectedItem is Model.Person
            );

            ItemSelectedCmd = new Command(DeleteCmd.ChangeCanExecute);
        }
    
    }
}
