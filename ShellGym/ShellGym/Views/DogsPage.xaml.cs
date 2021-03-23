using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogsPage : ContentPage
    {
        public DogsPage()
        {
            InitializeComponent();   
        }

        private async void btnNavigateBack_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../cats");            // går et niveau baglæns og sætter Route = cats
        }
    }
}