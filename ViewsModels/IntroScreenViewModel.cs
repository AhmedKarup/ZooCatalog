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
        private string _buttonText="Get started";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
            
        }
        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroScreen.Count - 1)
                {
                    ButtonText = "Enyoj";
                }
                else
                {
                    ButtonText = "Get started";
                }
            }));
        }

        public ObservableCollection<IntroScreenModel> IntroScreen { get; set; } = new ObservableCollection<IntroScreenModel>();

        #endregion

        public IntroScreenViewModel() {
            IntroScreen.Add(new IntroScreenModel
            {
                IntroTitle = "Dear animal lovers,We welcome you " +
                "to the official app of Safari",
                IntroDescription="Explore the largest zoo in Europe",
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
                IntroTitle = "Naslov2",
                IntroDescription = "Opis2",
                IntroImage = "intro3"

            });
        }
        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroScreen.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(DashboardView)}");
            }
            else
            {
               Position += 1;
            }
            
        });
    }
}
