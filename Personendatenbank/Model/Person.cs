using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personendatenbank.Model
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public bool IsMarried { get; set; }

        public Person()
        {
            Birthdate = DateTime.Now;

            Gender = Gender.Weiblich;
        }

        //Lab 10
        public static ObservableCollection<Person> PersonList { get; set; } = new ObservableCollection<Person>()
        {
            new Person(){ Name = "Anna Nass", Gender=Gender.Weiblich, IsMarried = true, Birthdate=new DateTime(2003, 12, 3) },
        };
    }
}
