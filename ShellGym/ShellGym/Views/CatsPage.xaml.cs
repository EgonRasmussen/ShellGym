/*
 * When a route from the Shell visual hierarchy is navigated to, a navigation stack isn't created. 
 * However, when a page that's not in the Shell visual hierarchy is navigated to, a navigation stack is created.
 * */

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

        // Absolute routes (The // Replaces the navigation stack - no Back button)
        private async void btnNavigateToAbout_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//about");
        }
        private async void btnNavigateToMonkeys_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//animals/monkeys");
        }

        private async void btnNavigateToDogs_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//animals/domestic/dogs");
        }


        // Relative routes (The // Replaces the navigation stack - no Back button)
        private async void btnNavigateToBears_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//bears");
        }

        // Global navigation (registrered routes in App.Shell constructor).  The matching page will be pushed to the navigation stack.
        // Only route and not //route is allowed.
        private async void btnNavigateToDogDetails_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("dogdetails");
        }

        // Overfør parametre via navigation
        private async void btnNavigateToElephant_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//animals/elephants/elephantdetails?name=24");
        }    
    }
}