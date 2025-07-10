using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio27 : UserControl
    {
        public Ejercicio27()
        {
            InitializeComponent();
        }
        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int n) && n >= 0)
            {
                long fact = 1;
                for (int i = 2; i <= n; i++)
                    fact *= i;

                txtResultado.Text = $"Factorial: {fact}";
            }
            else
            {
                MessageBox.Show("Ingresa un entero positivo.");
            }
        }

    }
}