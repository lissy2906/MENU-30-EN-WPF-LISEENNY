using System;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio14 : UserControl
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                txtResultado.Text = $"Fahrenheit: {fahrenheit:F2} °F";
            }
            else
                MessageBox.Show("Ingresa un número válido.");
        }
    }
}
