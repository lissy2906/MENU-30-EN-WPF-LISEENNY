using System.Windows;
using System.Windows.Controls;

namespace EjerciciosWPFLissy
{
    public partial class Ejercicio22 : UserControl
    {
        public Ejercicio22()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtDia.Text, out int dia))
            {
                string resultado = "";

                switch (dia)
                {
                    case 1: resultado = "Lunes"; break;
                    case 2: resultado = "Martes"; break;
                    case 3: resultado = "Miércoles"; break;
                    case 4: resultado = "Jueves"; break;
                    case 5: resultado = "Viernes"; break;
                    case 6: resultado = "Sábado"; break;
                    case 7: resultado = "Domingo"; break;
                    default: resultado = "Número fuera de rango (1-7)"; break;
                }

                txtResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

    }
}
