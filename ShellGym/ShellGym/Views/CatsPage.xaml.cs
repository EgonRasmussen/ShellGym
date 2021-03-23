using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
        }

        private async void btnNavigateToAbout_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//about");
        }

        private async void btnNavigateToDogs_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//animals/domestic/dogs");
        }    

        private async void btnNavigateToBears_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//bears");
        }
        private async void btnNavigateToDogDetails_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("dogdetails");
        }

        private async void btnNavigateToElephant_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//animals/elephants/elephantdetails?name=24");
        }
    }
}