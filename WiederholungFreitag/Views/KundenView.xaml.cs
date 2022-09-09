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
using System.Windows.Shapes;
using WiederholungFreitag.ViewModels;

namespace WiederholungFreitag.Views
{
    /// <summary>
    /// Interaction logic for KundenView.xaml
    /// </summary>
    public partial class KundenView : Window
    {
        KundenViewModel myModel = null;
        public KundenView()
        {
            InitializeComponent();
            myModel = new KundenViewModel();
            this.DataContext = myModel;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Demo(object sender, RoutedEventArgs e)
        {

        }

        private void SayHello(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myModel.AddPerson();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            myModel.DeletePerson();
        }
    }
}
