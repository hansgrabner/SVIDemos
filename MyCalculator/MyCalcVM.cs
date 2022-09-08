using System;
using System.Collections.Generic;
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

        public MyCalcVM()
        {
            _Sichtbarkeit = Visibility.Hidden;
        }

        private Visibility _Sichtbarkeit;

        public Visibility Sichtbarkeit
        {
            get { return _Sichtbarkeit; }

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


        internal void Calculat(string plusOderMinus)
        {
            if (plusOderMinus=="-")
            {
                Ergebnis = "1 - 2 = -1";
                Farbe = Brushes.Red;
            }
            else
            {
                Ergebnis = "1 + 2 = 3";
                Farbe = Brushes.Green;
            }

            RaiseEvent("Ergebnis");
        }
    }
}
