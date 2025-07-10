using System;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio25 : UserControl
    {
        public Ejercicio25()
        {
            InitializeComponent();
        }
        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtA.Text, out double a) &&
                double.TryParse(txtB.Text, out double b) &&
                double.TryParse(txtC.Text, out double c))
            {
                double menor = Math.Min(a, Math.Min(b, c));
                txtResultado.Text = $"El menor es: {menor}";
            }
            else
            {
                MessageBox.Show("Ingresa todos los números.");
            }
        }
    }
}