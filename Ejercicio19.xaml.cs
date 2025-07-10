using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio19 : UserControl
    {
        public Ejercicio19()
        {
            InitializeComponent();
        }

        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                txtResultado.Text = (num % 5 == 0)
                    ? "Es múltiplo de 5."
                    : "No es múltiplo de 5.";
            }
            else
                MessageBox.Show("Ingresa un número entero válido.");
        }
    }
}
