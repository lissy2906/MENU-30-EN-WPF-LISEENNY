using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtMonto.Text, out double monto))
            {
                double descuento = monto > 100 ? monto * 0.10 : monto * 0.02;
                double total = monto - descuento;
                txtResultado.Text = $"Descuento: {descuento:C2}, Total: {total:C2}";
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido");
            }
        }
    }
}

