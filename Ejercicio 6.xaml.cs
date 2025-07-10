using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                txtResultado.Text = (numero % 2 == 0)
                    ? "El número es par."
                    : "El número es impar.";
            }
            else
            {
                MessageBox.Show("Ingresa un número entero válido.");
            }
        }
    }
}

