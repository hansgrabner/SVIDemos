using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCommandSample
{
    internal class Person: INotifyPropertyChanged
    {
        public int PersonId { get; set; }

        private string _Firstname;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; 
            if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Firstname"));
                }
            }
        }

    }
}
