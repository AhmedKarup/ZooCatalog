using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp12.ViewsModels
{
    [QueryProperty(nameof(Animal), "Animal")]
    public partial class DetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        Animal animal;


        IGeolocation geolocation;

        public DetailViewModel(IGeolocation geolocation)
        {
            this.geolocation = geolocation;
        }
    }
}
