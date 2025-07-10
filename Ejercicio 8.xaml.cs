using System;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio8 : UserControl
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double a) &&
                double.TryParse(txtNum2.Text, out double b) &&
                double.TryParse(txtNum3.Text, out double c))
            {
                double mayor = Math.Max(a, Math.Max(b, c));
                txtResultado.Text = $"El número mayor es: {mayor}";
            }
            else
            {
                MessageBox.Show("Ingrese los tres números correctamente.");
            }
        }
    }
}

