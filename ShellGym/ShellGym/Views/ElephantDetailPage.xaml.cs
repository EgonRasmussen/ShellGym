
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellGym.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Name", "name")]
    public partial class ElephantDetailPage : ContentPage
    {
        public ElephantDetailPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public string Name
        {
            set { lblname.Text = value; }
        }

    }
}