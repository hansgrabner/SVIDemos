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

namespace WiederholungFreitag
{
    /// <summary>
    /// Interaction logic for MyHello.xaml
    /// </summary>
    public partial class MyHello : UserControl
    {
        public MyHello()
        {
            InitializeComponent();
           
            this.DataContext = this;
        }
        // public string Begruessung { get; set; }






        public string Greeting
        {
            get { return (string)GetValue(GreetingProperty); }
            set { SetValue(GreetingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Greeting.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GreetingProperty =
            DependencyProperty.Register("Greeting", typeof(string), typeof(MyHello), new PropertyMetadata(0));



    }
}
