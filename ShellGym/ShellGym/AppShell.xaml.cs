using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellGym
{
    public partial class AppShell : Shell
    {
        Random rand = new Random();

        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;      // nødvendig for at Command binding fungerer
        }


        public ICommand RandomCommand => new Command(
            async () => await DisplayAlert("Random", $"Dit tal er {rand.Next(0, 9)}", "Ok"));
        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    }
}