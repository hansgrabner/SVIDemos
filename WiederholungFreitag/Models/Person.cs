using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungFreitag.Models
{
    internal class Person : IDataErrorInfo, INotifyPropertyChanged
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set {
                _ID = value; 
            if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ID"));  
                }
            }
        }
        private string _Vorname;

        public string Vorname
        {
            get { return _Vorname; }
            set { _Vorname = value; }
        }
        private string _Geschlecht;

        public string Geschlecht
        {
            get { return _Geschlecht; }
            set {
                
                _Geschlecht = value; 
            }
        }

        private string _Profilbild;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Profilbild
        {
            get { return _Profilbild; }
            set { _Profilbild = value; }
        }

        public string Error => "Fehler";

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(ID):
                        if (ID < 0)
                            return "ID muss positiv sein";
                        else
                            return String.Empty;
                        break;

                }
                return string.Empty;
            }
        }

        public override string ToString()
        {
            return $"Person mit ID {ID} Vorname: {Vorname}";
        }



    }
}
