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
    }
}
