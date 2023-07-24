namespace CUBOYCUADRADO5834324;

public partial class MainPage : ContentPage
{
    /// <summary>
    /// <Createddate>24/07/2023</Createddate>
    /// <company>INDEL</company>
    /// <lastmodificationdate>24/07/2023</lastmodificationdate>
    /// <lastmodificationdescription>
    /// PROPIEDADES DEL BUTTON
    /// </lastmodificationdescription>
    /// <lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>

    public MainPage()
	{
		InitializeComponent();
	}


    /// <summary>
    /// SE EJECUTA AL PRESIONAR EL BOTON 
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        double num = Convert.ToDouble(N.Text);

        cuadra.Text = "Número al cuadrado: " + Math.Pow(num, 2);
        cubo.Text = "Número al cubo: " + Math.Pow(num, 3);
    }
}

