using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio9 : UserControl
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double num))
            {
                txtResultado.Text = $"El cuadrado es: {num * num}";
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }
}
