namespace WinFormsApp1ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int Monto_Inicial = int.Parse(textBox_monto.Text);
            int Tasa_Interes = int.Parse(textBoxTasaInt.Text);
            int Periodo = int.Parse(textBoxPeriodo.Text);
            int Capital_Final = Monto_Inicial * (int)(Math.Pow(Tasa_Interes + 1, Periodo));

            labelTotal.Text = $"El capital final del ahorro a plazo fijo es: {Capital_Final}";
        }
    }
}
