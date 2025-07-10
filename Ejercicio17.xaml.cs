using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio17 : UserControl
    {
        public Ejercicio17()
        {
            InitializeComponent();
        }

        private void BtnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
                txtResultado.Text = $"Resultado: {a * b}";
            else
                MessageBox.Show("Ingresa dos números válidos.");
        }
    }
}
