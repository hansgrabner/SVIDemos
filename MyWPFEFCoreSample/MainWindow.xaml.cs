using MyWPFEFCoreSample.Models;
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

namespace MyWPFEFCoreSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductsViewModel vm = null;
        public MainWindow()
        {
            InitializeComponent();
            /*
            ProductContext ctx = new ProductContext();
            ctx.Categories.Add(new Category() { CategoryId = 1, Name = "Cat 1" });
            ctx.Categories.Add(new Category() { CategoryId = 2, Name = "Cat 2" });
            this.DataContext = ctx.Categories.ToList();*/
           vm=new ProductsViewModel();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.AddCategory();
        }
    }
}
