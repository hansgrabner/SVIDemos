using Raetselraten.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselraten.ViewModels
{
    internal class AufgabenViewModel: INotifyPropertyChanged
    {
        public AufgabenViewModel()
        {
            var a1 = new Aufgabe() { Frage = "Hauptsdat von Österreich", AntwortA = "Wien", AntwortB = "DL", RichtigeAntwort = "A", AuswahlA = false, AuswahlB = false };
            var a2 = new Aufgabe() { Frage = "Welches Tier ist ein Säugetier", AntwortA = "Katze", AntwortB = "Wels", RichtigeAntwort = "A", AuswahlA = false, AuswahlB = false };
            var a3 = new Aufgabe() { Frage = "WPF steht für ", AntwortA = "Windows Present and Future", AntwortB = "Windows Presentation Foundation", RichtigeAntwort = "B", AuswahlA = false, AuswahlB = false };

            Aufgaben = new ObservableCollection<Aufgabe>();
            Aufgaben.Add(a1);
            Aufgaben.Add(a2);
            Aufgaben.Add(a3);
            AktuelleAufgabeIndex = 0;
        }
        public ObservableCollection<Aufgabe>    Aufgaben{ get; set; }
        private Aufgabe  _AktuelleAufgabe;

        private int _AktuelleAufgabeIndex;
        public int AktuelleAufgabeIndex
        {
            get { return _AktuelleAufgabeIndex; }
            set
            {
              
                _AktuelleAufgabeIndex = value;
                RaiseEvent("Statustext");
                RaiseEvent("AktuelleAufgabe");
                RaiseEvent("WeiterEnabled");
                RaiseEvent("ZurueckEnabled");


            }
        }
        public Aufgabe AktuelleAufgabe
        {
            get { return Aufgaben[AktuelleAufgabeIndex]; }
            set { _AktuelleAufgabe = value; }
        }

      

        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaiseEvent(string propertyName)
        {
            if (PropertyChanged!=null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
        }

      
        public bool WeiterEnabled
        {
            get
            {
                return AktuelleAufgabeIndex < Aufgaben.Count-1;
            }
        }

        public bool ZurueckEnabled
        {
            get
            {
                return AktuelleAufgabeIndex >0;
            }
        }

        public string Statustext
        {
            get
            {
                var countRichtig = Aufgaben.Where(a => a.IsRichtigBeantwortet == true).Count();

                var statusText = $"Aktuelle Aufgabe {AktuelleAufgabeIndex + 1} Richtig {countRichtig} Falsch {Aufgaben.Count - countRichtig}";
                
                return statusText;                

            }
        }

    }
}
