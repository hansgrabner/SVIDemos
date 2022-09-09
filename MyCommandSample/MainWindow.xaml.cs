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

namespace MyCommandSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICommand _changeColorCommand = null;
        public ICommand ChangeColorCmd
         => _changeColorCommand ??= new ChangeColorCommand();

        public MainWindow()
        {
            InitializeComponent();
            Person p = new Person() { Firstname="Hans", PersonId=-1};
            this.DataContext = p;
        }
    }
}
