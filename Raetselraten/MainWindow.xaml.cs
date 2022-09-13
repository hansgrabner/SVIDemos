using Raetselraten.Models;
using Raetselraten.ViewModels;
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

namespace Raetselraten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AufgabenViewModel viewModel = new AufgabenViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        private void Weiter(object sender, RoutedEventArgs e)
        {
            viewModel.AktuelleAufgabeIndex++;
        }

        private void Zurueck(object sender, RoutedEventArgs e)
        {
            viewModel.AktuelleAufgabeIndex--;
        }
    }
}
