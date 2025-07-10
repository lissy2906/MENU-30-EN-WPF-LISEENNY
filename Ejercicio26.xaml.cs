using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio26 : UserControl
    {
        public Ejercicio26()
        {
            InitializeComponent();
        }
        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double n))
            {
                if (n > 0)
                    txtResultado.Text = "Positivo";
                else if (n < 0)
                    txtResultado.Text = "Negativo";
                else
                    txtResultado.Text = "Es cero";
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }
    }
}