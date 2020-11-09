using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElephantsPage : ContentPage
    {
        public ElephantsPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            string elephantName = "Jumbo";
            await Shell.Current.GoToAsync($"//animals/elephants/elephantdetails?name={elephantName}");
        }
    }
}