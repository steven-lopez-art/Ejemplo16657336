    namespace Ejercicio1Invertir6657336
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
        
            //Ponemos el metodo con el que se ingresaran los numeros y se invertiran
            private void Button_Clicked(object sender, EventArgs e)
            {
                if (double.TryParse(Numero1.Text, out double num1) &&
                    double.TryParse(Numero2.Text, out double num2) &&
                    double.TryParse(Numero3.Text, out double num3) &&
                    double.TryParse(Numero4.Text, out double num4))
                {
                    double[] numeros = { num1, num2, num3, num4 };
                    Array.Reverse(numeros);
                
                //Aqui mostrara el resultado que serian los numeros invertidos
                    ResultadoLabel.Text = $"Números invertidos: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}";
                }
                //Si la persona no ingresa numeros correctos o numeros nulos o no ingresa
                //numeros dara un mensaje que ingrese todos los numeros y que sean validos
                else
                {
                    ResultadoLabel.Text = "Ingrese números válidos en todas las casillas.";
                }
            }
        }
    }