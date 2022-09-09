using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MyCalculator
{
    internal class MyCalcVM : INotifyPropertyChanged
    {
        public class Berechnung
        {
            public string Ausgabetext { get; set; }
            public Brush Farbe { get; set; }

            public bool Wissenschaftlich { get; set; }
        }
        public MyCalcVM()
        {
            _Sichtbarkeit = Visibility.Hidden;
            BerechnungsHistorie = new ObservableCollection<Berechnung>();
        }

        private Visibility _Sichtbarkeit;

        public Visibility Sichtbarkeit
        {
            get { return _Sichtbarkeit; }

        }

        public ObservableCollection<Berechnung> BerechnungsHistorie { get; set; }

        internal void Calculat(string plusOderMinus)
        {
            if (plusOderMinus == "-")
            {
                Ergebnis = "1 - 2 = -1";
                Farbe = Brushes.Red;
            }
            else
            {
                Ergebnis = "1 + 2 = 3";
                Farbe = Brushes.Green;
            }
            BerechnungsHistorie.Add(new Berechnung() { Ausgabetext=Ergebnis, Farbe = Farbe,Wissenschaftlich = IsWissenschaftlichChecked});
            RaiseEvent("Ergebnis");
            RaiseEvent("Farbe");
        }

        private bool _IsWissenschaftlichChecked;

        public bool IsWissenschaftlichChecked
        {
            get { return _IsWissenschaftlichChecked; }
            set { 
                _IsWissenschaftlichChecked = value;
                if (_IsWissenschaftlichChecked == true)
                   _Sichtbarkeit = Visibility.Visible;
                else
                    _Sichtbarkeit = Visibility.Hidden;
                RaiseEvent("Sichtbarkeit");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaiseEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        

        public string Statustext
        {
            get { return $"Heute ist der {System.DateTime.Now.ToLongDateString()} "; }
            
        }
        public bool Button1 { get; set; }
        public bool Button2 { get; set; }
        public bool Button3 { get; set; }

        public Brush Farbe { get; set; }

        public string Ergebnis { get; set; }


     
    }
}
