using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio7 : UserControl
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numero))
            {
                txtResultado.Text = $"El doble es: {numero * 2}";
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
