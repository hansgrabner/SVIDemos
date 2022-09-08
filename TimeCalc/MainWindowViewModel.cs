using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TimeCalc
{

    //MVVM -
    //Model (DB-Entity,
    //View - XAML - Declarativ Databinding, Commands,
    //ViewModel - Logik, PropertyChangeed
    internal class MainWindowViewModel: INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            _Farben = new List<string>
            {
                "Red","Green","Blue"
            };

            AusgewaehlteFarbe = _Farben[0];
        }
        public int MaxWertAusGUI { get; set; }
        private DateTime _Startzeit;

        public  DateTime Startzeit
        {
            get { return _Startzeit; }
            set { _Startzeit = value; }
        }

        private  Brush _MyBrush;

        public  Brush MyBrush
        {
            get {
                if (Laufzeit < MaxWertAusGUI)
                    if (IsChecked)
                        return Brushes.Red;
                    else
                        return Brushes.Orange;
                else
                    if (IsChecked)
                    return Brushes.Green;
                else
                    return Brushes.Blue;


                 }
            
        }

        public int TextGroesse
        {
            get
            {
                if (Laufzeit < MaxWertAusGUI)
                    return 20;
                else
                    return 40;

            }

        }

        private  double _Laufzeit;

        public  event PropertyChangedEventHandler? PropertyChanged;

        private bool _IsChecked;

        public bool IsChecked
        {
            get { return _IsChecked; }
            set { _IsChecked = value;
                if (PropertyChanged!=null)
                PropertyChanged(this, new PropertyChangedEventArgs("IsChecked"));
            }
        }

        public  void InformGUI()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("MyBrush"));
                PropertyChanged(this, new PropertyChangedEventArgs("Laufzeit"));
                PropertyChanged(this, new PropertyChangedEventArgs("TextGroesse"));
                
            }

        }

        private string _AusgewaehlteFarbe;

        public string AusgewaehlteFarbe
        {
            get { return _AusgewaehlteFarbe; }
            set { _AusgewaehlteFarbe = value; 
            
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AusgewaehlteFarbe"));
                }
            
            }
        }

    

        private List<string> _Farben;

        public List<string> Farben
        {
            get { 
                
                
                return _Farben; 
            }
           
        }


        public  double Laufzeit
        {
            get {

                var actualTime = System.DateTime.Now;
                var seconds = actualTime.Subtract(Startzeit).TotalSeconds;
                return seconds;

            }
            
        }




    }
}
