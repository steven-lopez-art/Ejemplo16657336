namespace Ejercicio2numeros6657336;

public partial class Formula : ContentPage
{
	public Formula()
	{
		InitializeComponent();
	}

    //Configuramos el boton con sus variables donde se guarden los 2 numeros
    //ingresados y se convierten los numeros a texto de cadenas y por ultimo se hace
    //la ecuacion((a + b) * (a + b)) / 2
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(Entry1.Text, out double a) && double.TryParse(Entry2.Text, out double b))
        {
            double resultado = ((a + b) * (a + b)) / 2;
            Entryr.Text = $"Resultado: {resultado}";
        }

        //Si la persona ingresa numeros incorrectos o nulos se le enviara el siguiente mensaje
        else
        {
            Entryr.Text = "Ingrese valores numéricos válidos para A y B.";
        }
    }
}