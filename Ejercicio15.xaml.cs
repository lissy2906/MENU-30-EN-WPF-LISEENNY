using System;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio15 : UserControl
    {
        public Ejercicio15()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double numero) && numero >= 0)
                txtResultado.Text = $"Raíz cuadrada: {Math.Sqrt(numero):F2}";
            else
                MessageBox.Show("Ingresa un número positivo válido.");
        }
    }
}
