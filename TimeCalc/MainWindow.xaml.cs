using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimeCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show(this.Properties["StartZeit"].ToString());
            //AusgabeTextBlock.Text = Application.Current.Properties["StartZeit"].ToString();
            this.DataContext = Application.Current.Properties["MainWindowViewModel"] as MainWindowViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            var actualTime = System.DateTime.Now;
            var startZeit = DateTime.Parse(Application.Current.Properties["StartZeit"].ToString());

            var seconds = actualTime.Subtract(startZeit).TotalSeconds;

            if (seconds < 30)
            {
                ((Button)sender).Background = Brushes.Red;
            }
            else
            {
                ((Button)sender).Background = Brushes.Green;
            }

            ((Button)sender).Content = System.DateTime.Now;
            */

            var dataContext = Application.Current.Properties["MainWindowViewModel"] as MainWindowViewModel;

            dataContext.InformGUI();    

            //Unit-Text
            if (dataContext.Laufzeit < dataContext.MaxWertAusGUI)
            {
             //   Assert.AreEqual(dataContext.MyBrush, Brushes.Green);
            }

        }

        private void neueFarbe_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = Application.Current.Properties["MainWindowViewModel"] as MainWindowViewModel;
            dataContext.Farben.Add("Orange");
        }

        int i = 10;
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            i++;
            this.Title = i.ToString();
        }
    }
}
