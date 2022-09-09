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

namespace MyUserControlSample
{
    /// <summary>
    /// Interaction logic for UserControlTestDP.xaml
    /// </summary>
    public partial class UserControlTestDP : UserControl
    {
        public UserControlTestDP()
        {
            InitializeComponent();
            this.DataContext = this;

        }



        public int MyNumber
        {
            get { return (int)GetValue(MyNumberProperty); }
            set { SetValue(MyNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyNumberProperty =
            DependencyProperty.Register("MyNumber", typeof(int), typeof(UserControlTestDP), new PropertyMetadata(0));



    }
}
