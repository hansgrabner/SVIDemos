using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetselraten.Models
{
    internal class Aufgabe: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaiseEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string RichtigeAntwort { get; set; }
        private string _Frage;

        public string Frage
        {
            get { return _Frage; }
            set { _Frage = value; }
        }
        private string _AntwortA;

        public string AntwortA
        {
            get { return _AntwortA; }
            set { _AntwortA = value; }
        }
        private string _AntwortB;

        public string AntwortB
        {
            get { return _AntwortB; }
            set { _AntwortB = value; }
        }

        private bool _AuswahlA;

        public bool AuswahlA
        {
            get { return _AuswahlA; }
            set { _AuswahlA = value;
                RaiseEvent("IsRichtigBeantwortet");
              
            }
        }

        private bool _AuswahlB;
        public bool AuswahlB
        {
            get { return _AuswahlB; }
            set { _AuswahlB = value;
                RaiseEvent("IsRichtigBeantwortet");
            }
        }

       
        public bool IsRichtigBeantwortet
        {
            get
            {
                if ((RichtigeAntwort == "A" && AuswahlA == true) || (RichtigeAntwort == "B" && AuswahlB == true))
                    return true;
                else
                    return false;
            }
            
        }

    }
}
