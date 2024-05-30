namespace Ejercicio4cuadrado6657336
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

        //Almanecamos el numero ingresado en una variable y lo multiplicamos
        //2 veces para sacar el cuadrado y multiplicamos 3 veces para sacar el subo
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumeroEntry.Text, out int numero) && numero > 0)
            {
                int cuadrado = numero * numero;
                int cubo = numero * numero * numero;

                //En La variable LabelResultado se mostrara la
                //multiplicacion de el cuadrado y el cubo
                LabelResultado.Text = $"Cuadrado: {cuadrado}, Cubo: {cubo}";
            }

            //Si la persona no ingresa numeros validos se mostrara el siguiente mensaje
            else
            {
                LabelResultado.Text = "Ingrese un número válido.";
            }
        }
    }

}
