using Xamarin.Forms;

namespace ShellGym.Views
{
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