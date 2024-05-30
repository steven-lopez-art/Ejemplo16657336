namespace Ejercicio5altura6657336
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
            if (double.TryParse(alturaEntry.Text, out double altura) &&
               double.TryParse(baseEntry.Text, out double baseRectangulo))
            {
                double perimetro = 2 * (altura + baseRectangulo);
                double superficie = altura * baseRectangulo;

                // Mostrar los resultados en etiquetas o en algún otro control
                ResultadoLabel1.Text = $"Perímetro: {perimetro}";
                ResultadoLabel2.Text = $"Superficie: {superficie}";
            }
            else
            {
                // Manejar errores de entrada inválida
                DisplayAlert("Error", "Ingresa valores numéricos válidos", "OK");
            }
        }
    }
}