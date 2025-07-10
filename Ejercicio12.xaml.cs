using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio12 : UserControl
    {
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= 12; i++)
                    sb.AppendLine($"{num} x {i} = {num * i}");
                txtTabla.Text = sb.ToString();
            }
            else
                MessageBox.Show("Ingresa un número entero válido.");
        }
    }
}

