using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsAppShell : Shell
    {
        Random rand = new Random();

        public TabsAppShell()
        {
            InitializeComponent();

            BindingContext = this;      // nødvendig for at Command binding fungerer
        }


        public ICommand RandomCommand => new Command(
            async () => await DisplayAlert("Random", $"Dit tal er {rand.Next(0, 9)}", "Ok"));
        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    }
}