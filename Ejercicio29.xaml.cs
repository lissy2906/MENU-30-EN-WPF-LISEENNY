using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{ 
    public partial class Ejercicio29 : UserControl
    {
        public Ejercicio29()
        {
            InitializeComponent();
        }
        private void BtnConvertir_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtDias.Text, out int dias) && dias >= 0)
            {
                int semanas = dias / 7;
                int resto = dias % 7;
                txtResultado.Text = $"{semanas} semana(s) y {resto} día(s)";
            }
            else
            {
                MessageBox.Show("Número inválido.");
            }
        }

    }
}