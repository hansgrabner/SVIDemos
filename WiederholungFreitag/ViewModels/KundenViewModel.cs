using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiederholungFreitag.Models;

namespace WiederholungFreitag.ViewModels
{
    internal class KundenViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public KundenViewModel()
        {
            Personen = new ObservableCollection<Person>();
            Personen.Add(new Person() { ID = 1, Geschlecht = "M", Vorname = "Hans", Profilbild = "/Images/Hans.jpg" });
            ID = -1;
            Vorname = "Anonym";
            Geschlecht = "Divers";
            Farbe = "Red";
        }
        //Liste von Personen
        //Statusanzeige
        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaiseEvent(string propertyName)
        {
            if (PropertyChanged!=null)
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
        }

        //List<Person> myPersonen = new List<Person>();

        public ObservableCollection<Person> Personen { get; set; }

        private string _Statusanzeige;

        public string Statusanzeige
        {
            get { return $"Derzeit sind {Personen.Count} Kunden vorhanden"; }
            set { _Statusanzeige = value; }
        }

        internal void DeletePerson()
        {
            Personen.RemoveAt(AusgewaehltePersonIndex);
            RaiseEvent("Statusanzeige");

        }

        private int _ID;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ID"));
                }
            }
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
        public string Vorname { get; set; }

        public string Geschlecht { get; set; }

        private Person _AusgewaehltePerson;

        public Person AusgewaehltePerson
        {
            get { return _AusgewaehltePerson; }
            set { 
                _AusgewaehltePerson = value;
                RaiseEvent("AusgewaehltePerson");

            }
        }


        /*
        private int _AusgewaehltePersonIndex;

        public int AusgewaehltePersonIndex
        {
            get { return _AusgewaehltePersonIndex; }
            set { _AusgewaehltePersonIndex = value; }
        }
        */

        public int AusgewaehltePersonIndex { get; set; }

        internal void AddPerson()
        {
            Personen.Add(new Person() { ID = ID, Vorname = Vorname, Geschlecht = Geschlecht });

           // Personen.Add(new Person() { ID = NeuePerson.ID, Vorname = NeuePerson.Vorname, Geschlecht = NeuePerson.Geschlecht });
            RaiseEvent("Statusanzeige");
        }

        public Person NeuePerson { get; set; }

        public string Farbe { get; set; }
    }
}
