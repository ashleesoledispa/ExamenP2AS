using ExamenP2AS.Views;
namespace ExamenP2AS
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ChisteBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync (new ChistePage());
        }

        private void AboutBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }

}
