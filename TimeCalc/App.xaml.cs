using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TimeCalc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //this.Properties["StartZeit"] = System.DateTime.Now;
            MainWindowViewModel m=new MainWindowViewModel();
            m.Startzeit = System.DateTime.Now;
            m.MaxWertAusGUI = 90;
            this.Properties["MainWindowViewModel"] = m;
            
            //MessageBox.Show(this.Properties["StartZeit"].ToString());
          //  MessageBox.Show(m.Startzeit.ToString());
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            /*
            var actualTime=System.DateTime.Now;
            var startZeit = DateTime.Parse(this.Properties["StartZeit"].ToString());

            var seconds = actualTime.Subtract(startZeit).TotalSeconds;

            var ausgabe = $"Sie waren {seconds} aktiv";

            MessageBox.Show(ausgabe);

            var v1 = "Hello";
            var v2 = 12;
          */

           
         


                              
            

        }
    }
}
