namespace Ejercicio3calificaciones6657336
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

        //Arreglamos el metodo de el boton para que calcule las 5 calificaciones
        //y convertimos los numeros ingresados
        private void Button_Clicked(object sender, EventArgs e)
        { 
            double[] calificaciones = new double[]
           {
                Convert.ToDouble(calificacion1.Text),
                Convert.ToDouble(calificacion2.Text),
                Convert.ToDouble(calificacion3.Text),
                Convert.ToDouble(calificacion4.Text),
                Convert.ToDouble(calificacion5.Text)
           };

            //y en la variable promedio se mostrara el resultado de todas las notas
            double promedio = calificaciones.Average();
            resultado.Text = $"Promedio: {promedio:F2}";
        }
    }
}