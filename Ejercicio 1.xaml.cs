using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtHoras.Text, out double horas) &&
                double.TryParse(txtTarifa.Text, out double tarifa))
            {
                double salario = horas <= 40 ? horas * tarifa : 40 * tarifa + (horas - 40) * tarifa * 1.5;
                txtResultado.Text = $"Salario: {salario:C2}";
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos");
            }
        }
    }
}
