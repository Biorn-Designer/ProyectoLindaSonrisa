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
using LindaSonrisa.Business;

namespace LindaSonrisa.Presentation
{
	/// <summary>
	/// Lógica de interacción para moduloReserva.xaml
	/// </summary>
	public partial class moduloReserva : Window
	{
		public moduloReserva()
		{
			InitializeComponent();
			CargarComboServicios();
		}

		private void btnVolver_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		public void CargarComboServicios()
		{
			List<Servicios> _listaServicios = new List<Servicios>();
			_listaServicios.Add(new Servicios { IdServicio = 1, NombreServicio = "Consulta Dental" });
			_listaServicios.Add(new Servicios { IdServicio = 2, NombreServicio = "Blanqueamiento" });

			this.cboServicio.DisplayMemberPath = "NombreServicio";
			this.cboServicio.SelectedValuePath = "IdServicio";
			this.cboServicio.ItemsSource = _listaServicios;
		}

	}
}
