namespace WinFormsApp2_ejercicio
{
    public partial class desafio_2 : Form
    {
        public desafio_2()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int Monto_Inicial = int.Parse(textBoxMontoIn.Text);
            int Tasa_Interes = int.Parse(textBoxIntereses.Text);
            int Tiempo = int.Parse(textBoxTiempo.Text);
            int Capital_Final = Monto_Inicial / (int) (1 - Math.Pow(1 + Tasa_Interes, -Tiempo)) / Tasa_Interes;


            labelTotal.Text = $"La cuota del prestamo es: {Capital_Final}";
        }
    }
}
