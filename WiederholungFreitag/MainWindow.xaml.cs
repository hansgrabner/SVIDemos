using Microsoft.Win32;
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
            CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);
            helpBinding.CanExecute += CanHelpExecute;
            helpBinding.Executed += HelpExecuted;
            CommandBindings.Add(helpBinding);
            MeineBegruesung = "Hello DL";
            this.DataContext = this;
        }

        private void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Here, you can set CanExecute to false if you want to prevent the command from 
           

             e.CanExecute = true;
        }
        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Look, it is not that difficult. Just type something!", "Help!");
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

        private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }
        private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }
        private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            // Create an open file dialog box and only show XAML files.
            var openDlg = new OpenFileDialog { Filter = "Text Files |*.txt" };
            // Did they click on the OK button?
            if (true == openDlg.ShowDialog())
            {

            }
        }

        public void btnClickMe_Clicked(object sender, RoutedEventArgs e)
        {
            // Do something when button is clicked.
            MessageBox.Show("Clicked the button");
        }

        public string MeineBegruesung { get; set; }
    }

}
