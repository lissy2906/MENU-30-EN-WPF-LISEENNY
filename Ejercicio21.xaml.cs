using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio21 : UserControl
    {
        public Ejercicio21()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, RoutedEventArgs e)
        {
            string letra = txtLetra.Text.ToLower();

            if (letra.Length == 1 && char.IsLetter(letra[0]))
            {
                if ("aeiou".Contains(letra))
                    txtResultado.Text = "Es una vocal.";
                else
                    txtResultado.Text = "Es una consonante.";
            }
            else
            {
                MessageBox.Show("Ingresa solo una letra.");
            }
        }
    }
}
