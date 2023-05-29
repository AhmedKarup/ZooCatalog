using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp12.Models
{
    public class Category
    {
        public string Image { get; set; }
        public string Name { get; set; }

        public Category(string image, string name) { 
            this.Image = image;
            this.Name = name;
        }
    }
}
