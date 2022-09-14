using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFEFCoreSample.Models
{
    internal class ProductsViewModel
    {
        ProductContext ctx = null;
        public ProductsViewModel()
        {
            ctx = new ProductContext();
           /*
            ctx.Categories.Add(new Category() { CategoryId = 1, Name = "Cat 1" });
            ctx.Categories.Add(new Category() { CategoryId = 2, Name = "Cat 2" });
            ctx.SaveChanges();
           */
            _Categories = new ObservableCollection<Category>();
            foreach (var item in ctx.Categories)
            {
                _Categories.Add(item);
            }
        }
        private ObservableCollection<Category> _Categories;

        public ObservableCollection<Category> Categories
        {
            get { return _Categories; }
            set { _Categories = value; }
        }

        public string NeueKategorie { get; set; }
        internal void AddCategory()
        {
            var newCategory = new Category() { Name = NeueKategorie };
            ctx.Add(newCategory);
            ctx.SaveChanges();
            _Categories.Add(newCategory);
        }
    }
}
