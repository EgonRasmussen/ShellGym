using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogDetailPage : ContentPage
    {
        public DogDetailPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {           
            await Shell.Current.GoToAsync("../../cats");    // går to niveauer baglæns og navigerer til cats. Sæt Watch til Shell.Current.CurrentState
        }
    }
}