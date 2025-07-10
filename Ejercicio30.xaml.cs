using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio30 : UserControl
    {
        public Ejercicio30()
        {
            InitializeComponent();
        }
        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            if (double.TryParse(txtNota.Text, out double nota))
            {
                txtResultado.Text = nota >= 70
                    ? $"{nombre} está aprobado."
                    : $"{nombre} está reprobado.";
            }
            else
            {
                MessageBox.Show("Nota inválida.");
            }
        }
    }
}