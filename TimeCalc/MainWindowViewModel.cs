using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TimeCalc
{
    internal class MainWindowViewModel: INotifyPropertyChanged
    {

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
                    return Brushes.Red;
                else 
                    return Brushes.Green;   

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

        public  void InformGUI()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("MyBrush"));
                PropertyChanged(this, new PropertyChangedEventArgs("Laufzeit"));
                PropertyChanged(this, new PropertyChangedEventArgs("TextGroesse"));
                
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
