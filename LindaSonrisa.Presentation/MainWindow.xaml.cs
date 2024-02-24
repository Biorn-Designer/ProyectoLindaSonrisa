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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LindaSonrisa.Business;

// Librerias Anexas

using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Data;


namespace LindaSonrisa.Presentation
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	/// 

	
	public partial class MainWindow : Window
	{


		public MainWindow()
		{
		
			InitializeComponent();
		}

		OracleConnection conexion = new OracleConnection("DATA SOURCE=localhost:1521/XEPDB1;USER ID=DJANGO;PASSWORD=DJANGO");

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			conexion.Open();
			OracleCommand comando = new OracleCommand("SELECT * FROM AUTH_USER WHERE USERNAME = :username AND PASSWORD = :password AND IS_SUPERUSER = 1", conexion);
			comando.Parameters.Add(":username", txtUsuario.Text);
			comando.Parameters.Add(":password", txtContrasena.Text);

			OracleDataReader lector = comando.ExecuteReader();

			if (lector.Read())
			{
				MessageBox.Show("¡BIENVENIDO ADMINISTRADOR!");
				menuInicio miVentana = new menuInicio();
				conexion.Close();
				miVentana.Show();
			}

			else
			{
				MessageBox.Show("Usuario Administrador Incorrecto");
				conexion.Close();
			}
		}

		private void btnSalir_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnCrearCuenta_Click(object sender, RoutedEventArgs e)
		{
			moduloCliente miVentana = new moduloCliente();
			miVentana.Owner = this;
			miVentana.ShowDialog();
		}
	}
}

