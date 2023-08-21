namespace Gasolina_3010746
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double galones = Convert.ToDouble(canGas.Text);

            double litros;

            litros = galones * 3.78541;

            cosTotal.Text = "El costo total es: $" + (litros * 1.168);
        }
    }
}