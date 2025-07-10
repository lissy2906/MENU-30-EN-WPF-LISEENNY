using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio20 : UserControl
    {
        public Ejercicio20()
        {
            InitializeComponent();
        }

        private void BtnComparar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
                txtResultado.Text = (a == b) ? "Los números son iguales." : "Los números son diferentes.";
            else
                MessageBox.Show("Ingresa dos números válidos.");
        }
    }
}
