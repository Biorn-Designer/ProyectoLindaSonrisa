using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LindaSonrisa.Presentation
{
	/// <summary>
	/// Lógica de interacción para menuInicio.xaml
	/// </summary>
	public partial class menuInicio : Window
	{
		public menuInicio()
		{
			InitializeComponent();
		}

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_clients.Visibility = Visibility.Collapsed;
                tt_reservs.Visibility = Visibility.Collapsed;
                tt_ubication.Visibility = Visibility.Collapsed;
                tt_settings.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_clients.Visibility = Visibility.Visible;
                tt_reservs.Visibility = Visibility.Visible;
                tt_ubication.Visibility = Visibility.Visible;
                tt_settings.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Boton Cerrar
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            moduloCliente miVentana = new moduloCliente();
            miVentana.Owner = this;
            miVentana.ShowDialog();
        }

		private void btnSalir_Click(object sender, RoutedEventArgs e)
		{
            Close();
		}

		private void btnReservas_Click(object sender, RoutedEventArgs e)
		{
            moduloReserva miVentana = new moduloReserva();
            miVentana.Owner = this;
            miVentana.ShowDialog();
        }
	}
}
