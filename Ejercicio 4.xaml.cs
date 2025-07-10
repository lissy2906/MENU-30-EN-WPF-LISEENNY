using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void BtnComparar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double num1) &&
                double.TryParse(txtNum2.Text, out double num2))
            {
                if (num1 > num2)
                    txtResultado.Text = $"El número mayor es: {num1}";
                else if (num2 > num1)
                    txtResultado.Text = $"El número mayor es: {num2}";
                else
                    txtResultado.Text = "Ambos números son iguales.";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa dos números válidos.");
            }
        }
    }
}

