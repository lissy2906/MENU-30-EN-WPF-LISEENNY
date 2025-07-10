using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio10 : UserControl
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
                txtResultado.Text = edad >= 18 ? "Es mayor de edad." : "Es menor de edad.";
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.");
            }
        }
    }
}

