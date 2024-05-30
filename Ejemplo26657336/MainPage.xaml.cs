namespace Ejercicio26657336
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presioname de nuevo";
        }
    }

}
