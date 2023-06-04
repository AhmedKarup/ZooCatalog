using CommunityToolkit.Mvvm.ComponentModel;
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
        public ObservableCollection<Category> Categories { get; } = new ObservableCollection<Category>();

        public List<Animal> AnimalsCopy = new List<Animal>();
        public ObservableCollection<Animal> Animals { get; set; } = new ObservableCollection<Animal>();

        [ObservableProperty]
        public Animal animal;

        public DashboardViewModel()
        {
            AddCategories();
            AddAnimals();
           
        }

        [ObservableProperty]
        public Category selectedCategory;

        public void ChangeCategorie()
        {
            Animal = null;
            if (SelectedCategory.Name == "All") {
                try
                {
                    Animals.Clear();
                    foreach (Animal animal in AnimalsCopy)
                    {
                        Animals.Add(animal);
                    }
                }catch (Exception) { }
                        
            }
            else {
                try
                {
                    List<Animal> filteredAnimals = AnimalsCopy.Where(animal => animal.Category.Name == SelectedCategory.Name).ToList();
                    Animals.Clear();
                    foreach (Animal animal in filteredAnimals)
                    {
                        Animals.Add(animal);
                    }
                }
                catch (Exception) { }
                   
            }
        }

        public void AddAnimals()
        {
            Animals.Add(new Animal("lion1.jpg", "Majmun", "Ja sam Ahmed","7km", Categories[1]));
            Animals.Add(new Animal("profilepic2.jpg", "Majmun", "Ja sam Ahmed", "7km", Categories[1]));
            Animals.Add(new Animal("profilepic3.jpg", "Tigar", "Ja sam Ahmed", "7km", Categories[1]));
            Animals.Add(new Animal("profilepic.jpg", "Tigar", "Ja sam Ahmed", "7km", Categories[2]));
            Animals.Add(new Animal("profilepic.jpg", "Tigar", "Ja sam Ahmed", "7km", Categories[2]));
            Animals.Add(new Animal("profilepic.jpg", "Tigar", "Ja sam Ahmed", "7km", Categories[2]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[3]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[3]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[3]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[4]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[4]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[4]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[5]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[5]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[6]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[6]));
            Animals.Add(new Animal("intro1.jpg", "Slon", "Ja sam slon", "7km", Categories[7]));


            foreach (Animal animal in Animals)
            {
                AnimalsCopy.Add(animal);
            }
            
        }
        public void AddCategories() {
            Categories.Add(new Category("ff", "All"));//0
            Categories.Add(new Category("intro1.jpg", "Lions")); //1
            Categories.Add(new Category("ff", "Tigers")); //2
            Categories.Add(new Category("ff", "Wolfs"));//3
            Categories.Add(new Category("ff", "Gorillas"));//4
            Categories.Add(new Category("ff", "Monkeys")); //5
            Categories.Add(new Category("ff", "Polar bears"));//6
            Categories.Add(new Category("ff", "Elephants"));//7
            Categories.Add(new Category("ff", "Pandas"));//8
            Categories.Add(new Category("ff", "Birds"));//9
            Categories.Add(new Category("ff", "Bears"));//10
            Categories.Add(new Category("ff", "Koalas"));//11
            Categories.Add(new Category("ff", "Snakes"));//12
            Categories.Add(new Category("ff", "Penguins"));//13
            Categories.Add(new Category("ff", "Lizards"));//14
            Categories.Add(new Category("ff", "Giraffes"));//15
            Categories.Add(new Category("ff", "Hippos"));//16


            SelectedCategory = Categories[0];
        }
       

    }
}



