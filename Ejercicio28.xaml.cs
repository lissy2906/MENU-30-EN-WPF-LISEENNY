using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio28 : UserControl
    {
        public Ejercicio28()
        {
            InitializeComponent();
        }
        private void BtnConvertir_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtF.Text, out double f))
            {
                double c = (f - 32) * 5 / 9;
                txtResultado.Text = $"Celsius: {c:F2} °C";
            }
            else
            {
                MessageBox.Show("Valor inválido.");
            }
        }

    }
}