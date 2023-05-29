using MauiApp12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp12.ViewsModels
{
    public partial class DashboardViewModel : BaseViewModel
    {
        public ObservableCollection<Category> Categories { get; } = new ();  

        public DashboardViewModel() {
            Categories.Add(new Category("ff", "Majmuni"));
            Categories.Add(new Category("ff", "Ahmedi"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
            Categories.Add(new Category("ff", "Lav"));
        }
    }
}
