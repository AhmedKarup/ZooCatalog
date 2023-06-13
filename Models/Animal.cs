
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
        public string Location { get; set; }
        public string Distance { get; set; }
        public string Population { get; set; }
        public string Rating { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Speed { get; set; }
        public Category Category { get; set; }
        public string Opis { get; set; } 
        public double Long { get; set; }
        public double Lat { get; set; } 
      
        
        
        public Animal(string Slike, string Naziv,string Location, string Distance,string Population,string Rating,string Height,string Weight,string Speed, string Opis, Category Category, double Long, double Lat)
        {
            this.Slike = Slike;
            this.Naziv = Naziv;
            this.Location = Location;
            this.Distance = Distance;
            this.Population = Population;
            this.Rating = Rating;
            this.Height = Height;
            this.Weight = Weight;
            this.Speed = Speed;
            this.Opis = Opis;
            this.Category = Category;
            this.Long = Long;
            this.Lat = Lat;
           
        }

        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}


