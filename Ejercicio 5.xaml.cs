using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numero))
            {
                txtResultado.Text = numero >= 0
                    ? "El número es positivo."
                    : "El número es negativo.";
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
