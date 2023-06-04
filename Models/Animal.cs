using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp12.Models
{
    public  class Animal
    {
        public string Slike { get; set; }
        public string Naziv { get;set; }
        public string Distance { get; set; }
        public Category Category { get; set; }
        public string Opis { get; set; }  
        
        public Animal(string Slike, string Naziv, string Opis,string Distance, Category Category)
        {
            this.Slike = Slike;
            this.Naziv = Naziv;
            this.Distance = Distance;
            this.Opis = Opis;
            this.Category = Category;
        }

        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}


