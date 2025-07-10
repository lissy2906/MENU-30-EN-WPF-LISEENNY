using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio16 : UserControl
    {
        public Ejercicio16()
        {
            InitializeComponent();
        }

        private void BtnRestar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
                txtResultado.Text = $"Resultado: {a - b}";
            else
                MessageBox.Show("Ingresa dos números válidos.");
        }
    }
}
