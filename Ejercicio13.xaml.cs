using System;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio13 : UserControl
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero.Text, out double num))
                txtResultado.Text = $"Valor absoluto: {Math.Abs(num)}";
            else
                MessageBox.Show("Número inválido.");
        }
    }
}

