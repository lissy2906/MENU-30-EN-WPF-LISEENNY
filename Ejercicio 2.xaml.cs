using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtSueldo.Text, out double sueldo))
            {
                double descuento = 0;
                if (sueldo <= 1000)
                    descuento = sueldo * 0.10;
                else if (sueldo <= 2000)
                    descuento = 1000 * 0.10 + (sueldo - 1000) * 0.05;
                else
                    descuento = 1000 * 0.10 + 1000 * 0.05 + (sueldo - 2000) * 0.03;

                double neto = sueldo - descuento;
                txtResultado.Text = $"Descuento: {descuento:C2}, Neto: {neto:C2}";
            }
            else
            {
                MessageBox.Show("Ingrese un sueldo válido");
            }
        }
    }
}
