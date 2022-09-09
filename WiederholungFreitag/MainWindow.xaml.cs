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
using WiederholungFreitag.Views;

namespace WiederholungFreitag
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void showKunden_Click(object sender, RoutedEventArgs e)
        {
            KundenView view = new KundenView();
            view.Show();
        }
    }

}
