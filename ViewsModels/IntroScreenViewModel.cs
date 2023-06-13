using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp12.Models;
using MauiApp12.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp12.ViewsModels
{
    public partial class IntroScreenViewModel:BaseViewModel
    {
        #region Properties

        [ObservableProperty]
        public string buttonText = "Next";

        [ObservableProperty]
        public int position = 0;

        public ObservableCollection<IntroScreenModel> IntroScreen { get; set; } = new ObservableCollection<IntroScreenModel>();

        #endregion

        public IntroScreenViewModel() {
            IntroScreen.Add(new IntroScreenModel
            {
                IntroTitle = "Dear animal lovers,We welcome you " +
                "to the official app of Safari",
                IntroDescription= "Explore the largest zoo in Europe,",
                IntroImage= "intro1"

            });

            IntroScreen.Add(new IntroScreenModel
            {
                IntroTitle = "Naslov2",
                IntroDescription = "Opis",
                IntroImage = "intro2"

            });
            IntroScreen.Add(new IntroScreenModel
            {
                IntroTitle = "Naslov3",
                IntroDescription = "Opis3",
                IntroImage = "intro3"

            });
        }

        [RelayCommand]
        public async void Next()
        {

            if ((Position >= IntroScreen.Count - 1) && IntroScreen.Count>2)
            {
                await AppShell.Current.GoToAsync($"//{nameof(DashboardView)}");
            }
            else
            {
                Position += 1;

            }
            
        }
    }
}
