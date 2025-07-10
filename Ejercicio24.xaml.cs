using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio24 : UserControl
    {
        public Ejercicio24()
        {
            InitializeComponent();
        }
        private void BtnEvaluar_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNota.Text, out double nota))
            {
                txtResultado.Text = nota >= 70 ? "Aprobado ✅" : "Reprobado ❌";
            }
            else
            {
                MessageBox.Show("Ingresa una nota válida.");
            }
        }
    }
}
