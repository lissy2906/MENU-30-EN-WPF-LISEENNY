using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio23 : UserControl
    {
        public Ejercicio23()
        {
            InitializeComponent();
        }
        private void BtnComparar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double n1) &&
                double.TryParse(txtNum2.Text, out double n2))
            {
                txtResultado.Text = n1 > n2 ? $"El mayor es: {n1}" :
                                     n2 > n1 ? $"El mayor es: {n2}" :
                                     "Son iguales";
            }
            else
            {
                MessageBox.Show("Ingresa números válidos.");
            }
        }
    }
}

