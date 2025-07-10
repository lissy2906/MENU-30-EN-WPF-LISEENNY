using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio18 : UserControl
    {
        public Ejercicio18()
        {
            InitializeComponent();
        }

        private void BtnDividir_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
            {
                if (b != 0)
                    txtResultado.Text = $"Resultado: {a / b:F2}";
                else
                    txtResultado.Text = "Error: división por cero.";
            }
            else
                MessageBox.Show("Ingresa dos números válidos.");
        }
    }
}
