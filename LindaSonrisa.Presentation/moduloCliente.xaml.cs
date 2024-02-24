using System;
using System.Collections.Generic;
using System.Data.OracleClient;
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
using System.Drawing;
using System.Data;
using MessageBox = System.Windows.MessageBox;
using DataGrid = System.Windows.Controls.DataGrid;




namespace LindaSonrisa.Presentation
{
	/// <summary>
	/// Lógica de interacción para moduloCliente.xaml
	/// </summary>
	public partial class moduloCliente : Window
	{
		OracleConnection conexion = new OracleConnection("DATA SOURCE=localhost:1521/XEPDB1;USER ID=DJANGO;PASSWORD=DJANGO");


		public moduloCliente()
		{
			InitializeComponent();
			CargarComboRegiones();
			CargarComboComunas();
		}

		private void btnVolver_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		#region Combo Regiones
			public void CargarComboRegiones()
			{
				List<Regiones> listaRegiones = new List<Regiones>();
				listaRegiones.Add(new Regiones {IdRegion = 1, NombreRegion="Tarapacá"});
				listaRegiones.Add(new Regiones { IdRegion = 2, NombreRegion = "Antofagasta" });
				listaRegiones.Add(new Regiones { IdRegion = 3, NombreRegion = "Coquimbo" });
				listaRegiones.Add(new Regiones { IdRegion = 4, NombreRegion = "Valparaíso" });
				listaRegiones.Add(new Regiones { IdRegion = 5, NombreRegion = "O'Higgins" });
				listaRegiones.Add(new Regiones { IdRegion = 6, NombreRegion = "El Maule" });
				listaRegiones.Add(new Regiones { IdRegion = 7, NombreRegion = "El Bio Bio" });
				listaRegiones.Add(new Regiones { IdRegion = 8, NombreRegion = "La Araucanía" });
				listaRegiones.Add(new Regiones { IdRegion = 9, NombreRegion = "Los Lagos" });
				listaRegiones.Add(new Regiones { IdRegion = 10, NombreRegion = "Aysen" });
				listaRegiones.Add(new Regiones { IdRegion = 11, NombreRegion = "Magallanes y Antártica" });
				listaRegiones.Add(new Regiones { IdRegion = 12, NombreRegion = "Metropolitana" });
				listaRegiones.Add(new Regiones { IdRegion = 13, NombreRegion = "Los Rios" });
				listaRegiones.Add(new Regiones { IdRegion = 14, NombreRegion = "Arica y Parinacota" });
				listaRegiones.Add(new Regiones { IdRegion = 15, NombreRegion = "Ñuble" });

				this.cboRegion.DisplayMemberPath = "NombreRegion";
				this.cboRegion.SelectedValuePath = "IdRegion";
				this.cboRegion.ItemsSource = listaRegiones;
			}
		#endregion

		#region Combo Comunas
			public void CargarComboComunas()
			{
				List<Comunas> listaComunas = new List<Comunas>();
				listaComunas.Add(new Comunas { IdComuna = 1, NombreComuna = "Puente Alto" });
				listaComunas.Add(new Comunas { IdComuna = 2, NombreComuna = "Maipú" });
				listaComunas.Add(new Comunas { IdComuna = 3, NombreComuna = "Santiago" });
				listaComunas.Add(new Comunas { IdComuna = 4, NombreComuna = "La Florida" });
				listaComunas.Add(new Comunas { IdComuna = 5, NombreComuna = "Antofagasta" });
				listaComunas.Add(new Comunas { IdComuna = 6, NombreComuna = "Viña del Mar" });
				listaComunas.Add(new Comunas { IdComuna = 7, NombreComuna = "San Bernardo" });
				listaComunas.Add(new Comunas { IdComuna = 8, NombreComuna = "Valparaiso" });
				listaComunas.Add(new Comunas { IdComuna = 9, NombreComuna = "Las Condes" });
				listaComunas.Add(new Comunas { IdComuna = 10, NombreComuna = "Temuco" });
				listaComunas.Add(new Comunas { IdComuna = 11, NombreComuna = "Puerto Montt" });
				listaComunas.Add(new Comunas { IdComuna = 12, NombreComuna = "Rancagua" });
				listaComunas.Add(new Comunas { IdComuna = 13, NombreComuna = "Peñalolén" });
				listaComunas.Add(new Comunas { IdComuna = 14, NombreComuna = "Pudahuel" });
				listaComunas.Add(new Comunas { IdComuna = 15, NombreComuna = "Coquimbo" });
				listaComunas.Add(new Comunas { IdComuna = 16, NombreComuna = "Concepción" });
				listaComunas.Add(new Comunas { IdComuna = 17, NombreComuna = "Talca" });
				listaComunas.Add(new Comunas { IdComuna = 18, NombreComuna = "Quilicura" });
				listaComunas.Add(new Comunas { IdComuna = 19, NombreComuna = "Ñuñoa" });
				listaComunas.Add(new Comunas { IdComuna = 20, NombreComuna = "Los Angeles" });
				listaComunas.Add(new Comunas { IdComuna = 21, NombreComuna = "Iquique" });
				listaComunas.Add(new Comunas { IdComuna = 22, NombreComuna = "Chillán" });
				listaComunas.Add(new Comunas { IdComuna = 23, NombreComuna = "La Pintana" });
				listaComunas.Add(new Comunas { IdComuna = 24, NombreComuna = "Valdivia" });
				listaComunas.Add(new Comunas { IdComuna = 25, NombreComuna = "Calama" });
				listaComunas.Add(new Comunas { IdComuna = 26, NombreComuna = "El Bosque" });
				listaComunas.Add(new Comunas { IdComuna = 27, NombreComuna = "Osorno" });
				listaComunas.Add(new Comunas { IdComuna = 28, NombreComuna = "Recoleta" });
				listaComunas.Add(new Comunas { IdComuna = 29, NombreComuna = "Copiapó" });
				listaComunas.Add(new Comunas { IdComuna = 30, NombreComuna = "Talcahuano" });
				listaComunas.Add(new Comunas { IdComuna = 31, NombreComuna = "Quilpué" });
				listaComunas.Add(new Comunas { IdComuna = 32, NombreComuna = "Curicó" });
				listaComunas.Add(new Comunas { IdComuna = 33, NombreComuna = "Renca" });
				listaComunas.Add(new Comunas { IdComuna = 34, NombreComuna = "Estación Central" });
				listaComunas.Add(new Comunas { IdComuna = 35, NombreComuna = "Colina" });
				listaComunas.Add(new Comunas { IdComuna = 36, NombreComuna = "Providencia" });
				listaComunas.Add(new Comunas { IdComuna = 37, NombreComuna = "Cerro Navia" });
				listaComunas.Add(new Comunas { IdComuna = 38, NombreComuna = "San Pedro de La Paz" });
				listaComunas.Add(new Comunas { IdComuna = 39, NombreComuna = "Punta Arenas" });
				listaComunas.Add(new Comunas { IdComuna = 40, NombreComuna = "Conchalí" });
				listaComunas.Add(new Comunas { IdComuna = 41, NombreComuna = "Villa Alemana" });
				listaComunas.Add(new Comunas { IdComuna = 42, NombreComuna = "Melipilla" });
				listaComunas.Add(new Comunas { IdComuna = 43, NombreComuna = "La Granja" });
				listaComunas.Add(new Comunas { IdComuna = 44, NombreComuna = "Macúl" });
				listaComunas.Add(new Comunas { IdComuna = 45, NombreComuna = "Coronel" });
				listaComunas.Add(new Comunas { IdComuna = 46, NombreComuna = "Ovalle" });
				listaComunas.Add(new Comunas { IdComuna = 47, NombreComuna = "Quinta Normal" });
				listaComunas.Add(new Comunas { IdComuna = 48, NombreComuna = "Alto Hospicio" });
				listaComunas.Add(new Comunas { IdComuna = 49, NombreComuna = "San Miguel" });
				listaComunas.Add(new Comunas { IdComuna = 50, NombreComuna = "Lo Barnechea" });
				listaComunas.Add(new Comunas { IdComuna = 51, NombreComuna = "Lampa" });
				listaComunas.Add(new Comunas { IdComuna = 52, NombreComuna = "Pedro Aguirrez Cerda" });
				listaComunas.Add(new Comunas { IdComuna = 53, NombreComuna = "Independencia" });
				listaComunas.Add(new Comunas { IdComuna = 54, NombreComuna = "Lo Espejo" });
				listaComunas.Add(new Comunas { IdComuna = 55, NombreComuna = "Huechuraba" });
				listaComunas.Add(new Comunas { IdComuna = 56, NombreComuna = "Buin" });
				listaComunas.Add(new Comunas { IdComuna = 57, NombreComuna = "Lo Prado" });
				listaComunas.Add(new Comunas { IdComuna = 58, NombreComuna = "San Joaquín" });
				listaComunas.Add(new Comunas { IdComuna = 59, NombreComuna = "Linares" });
				listaComunas.Add(new Comunas { IdComuna = 60, NombreComuna = "La Reina" });
				listaComunas.Add(new Comunas { IdComuna = 61, NombreComuna = "Hualpén" });
				listaComunas.Add(new Comunas { IdComuna = 62, NombreComuna = "San Antonio" });
				listaComunas.Add(new Comunas { IdComuna = 63, NombreComuna = "Quillota" });
				listaComunas.Add(new Comunas { IdComuna = 64, NombreComuna = "Peñaflor" });
				listaComunas.Add(new Comunas { IdComuna = 65, NombreComuna = "La Cisterna" });
				listaComunas.Add(new Comunas { IdComuna = 66, NombreComuna = "Chinguayante" });
				listaComunas.Add(new Comunas { IdComuna = 67, NombreComuna = "Vitacura" });
				listaComunas.Add(new Comunas { IdComuna = 68, NombreComuna = "San Ramón" });
				listaComunas.Add(new Comunas { IdComuna = 69, NombreComuna = "Cerrillos" });
				listaComunas.Add(new Comunas { IdComuna = 70, NombreComuna = "San Felipe" });
				listaComunas.Add(new Comunas { IdComuna = 71, NombreComuna = "Padre Las Casas" });
				listaComunas.Add(new Comunas { IdComuna = 72, NombreComuna = "Talagante" });
				listaComunas.Add(new Comunas { IdComuna = 73, NombreComuna = "San Fernando" });
				listaComunas.Add(new Comunas { IdComuna = 74, NombreComuna = "Paine" });
				listaComunas.Add(new Comunas { IdComuna = 75, NombreComuna = "Los Andes" });
				listaComunas.Add(new Comunas { IdComuna = 76, NombreComuna = "Padre Hurtado" });
				listaComunas.Add(new Comunas { IdComuna = 77, NombreComuna = "Rengo" });
				listaComunas.Add(new Comunas { IdComuna = 78, NombreComuna = "Coyaique" });
				listaComunas.Add(new Comunas { IdComuna = 79, NombreComuna = "Villarica" });
				listaComunas.Add(new Comunas { IdComuna = 80, NombreComuna = "Tomé" });
				listaComunas.Add(new Comunas { IdComuna = 81, NombreComuna = "Angol" });
				listaComunas.Add(new Comunas { IdComuna = 82, NombreComuna = "San Carlos" });
				listaComunas.Add(new Comunas { IdComuna = 83, NombreComuna = "Machalí" });
				listaComunas.Add(new Comunas { IdComuna = 84, NombreComuna = "Vallenar" });
				listaComunas.Add(new Comunas { IdComuna = 85, NombreComuna = "La Calera" });
				listaComunas.Add(new Comunas { IdComuna = 86, NombreComuna = "Maule" });
				listaComunas.Add(new Comunas { IdComuna = 87, NombreComuna = "Penco" });
				listaComunas.Add(new Comunas { IdComuna = 88, NombreComuna = "San Vicente" });
				listaComunas.Add(new Comunas { IdComuna = 89, NombreComuna = "Limache" });
				listaComunas.Add(new Comunas { IdComuna = 90, NombreComuna = "Constitución" });
				listaComunas.Add(new Comunas { IdComuna = 91, NombreComuna = "Molina" });
				listaComunas.Add(new Comunas { IdComuna = 92, NombreComuna = "San Javier" });
				listaComunas.Add(new Comunas { IdComuna = 93, NombreComuna = "Puerto Varas" });
				listaComunas.Add(new Comunas { IdComuna = 94, NombreComuna = "Castro" });
				listaComunas.Add(new Comunas { IdComuna = 95, NombreComuna = "Lota" });
				listaComunas.Add(new Comunas { IdComuna = 96, NombreComuna = "San Clemente" });
				listaComunas.Add(new Comunas { IdComuna = 97, NombreComuna = "Concón" });
				listaComunas.Add(new Comunas { IdComuna = 98, NombreComuna = "Parral" });
				listaComunas.Add(new Comunas { IdComuna = 99, NombreComuna = "Cauquenes" });
				listaComunas.Add(new Comunas { IdComuna = 100, NombreComuna = "Ancud" });
				listaComunas.Add(new Comunas { IdComuna = 101, NombreComuna = "La Unión" });
				listaComunas.Add(new Comunas { IdComuna = 102, NombreComuna = "Lautaro" });
				listaComunas.Add(new Comunas { IdComuna = 103, NombreComuna = "Santa Cruz" });
				listaComunas.Add(new Comunas { IdComuna = 104, NombreComuna = "Arauco" });
				listaComunas.Add(new Comunas { IdComuna = 105, NombreComuna = "Isla de Maipo" });
				listaComunas.Add(new Comunas { IdComuna = 106, NombreComuna = "El Monte" });
				listaComunas.Add(new Comunas { IdComuna = 107, NombreComuna = "Chimbaronogo" });
				listaComunas.Add(new Comunas { IdComuna = 108, NombreComuna = "La Ligua" });
				listaComunas.Add(new Comunas { IdComuna = 109, NombreComuna = "Panguipulli" });
				listaComunas.Add(new Comunas { IdComuna = 110, NombreComuna = "Cañete" });
				listaComunas.Add(new Comunas { IdComuna = 111, NombreComuna = "Victoria" });
				listaComunas.Add(new Comunas { IdComuna = 112, NombreComuna = "Calbuco" });
				listaComunas.Add(new Comunas { IdComuna = 113, NombreComuna = "Graneros" });
				listaComunas.Add(new Comunas { IdComuna = 114, NombreComuna = "Curacaví" });
				listaComunas.Add(new Comunas { IdComuna = 115, NombreComuna = "Nueva Imperial" });
				listaComunas.Add(new Comunas { IdComuna = 116, NombreComuna = "Curanilahue" });
				listaComunas.Add(new Comunas { IdComuna = 117, NombreComuna = "Quintero" });
				listaComunas.Add(new Comunas { IdComuna = 118, NombreComuna = "Rio Bueno" });
				listaComunas.Add(new Comunas { IdComuna = 119, NombreComuna = "Chillán Viejo" });
				listaComunas.Add(new Comunas { IdComuna = 120, NombreComuna = "Illapel" });
				listaComunas.Add(new Comunas { IdComuna = 121, NombreComuna = "Monte Patria" });
				listaComunas.Add(new Comunas { IdComuna = 122, NombreComuna = "Longaví" });
				listaComunas.Add(new Comunas { IdComuna = 123, NombreComuna = "Mulchén" });
				listaComunas.Add(new Comunas { IdComuna = 124, NombreComuna = "Salamanca" });
				listaComunas.Add(new Comunas { IdComuna = 125, NombreComuna = "Teno" });
				listaComunas.Add(new Comunas { IdComuna = 126, NombreComuna = "Cabrero" });
				listaComunas.Add(new Comunas { IdComuna = 127, NombreComuna = "Pucón" });
				listaComunas.Add(new Comunas { IdComuna = 128, NombreComuna = "Vilcún" });
				listaComunas.Add(new Comunas { IdComuna = 129, NombreComuna = "Requinoa" });
				listaComunas.Add(new Comunas { IdComuna = 130, NombreComuna = "Vicuña" });
				listaComunas.Add(new Comunas { IdComuna = 131, NombreComuna = "Quellón" });
				listaComunas.Add(new Comunas { IdComuna = 132, NombreComuna = "Coihueco" });
				listaComunas.Add(new Comunas { IdComuna = 133, NombreComuna = "Casa Blanca" });
				listaComunas.Add(new Comunas { IdComuna = 134, NombreComuna = "Pirque" });
				listaComunas.Add(new Comunas { IdComuna = 135, NombreComuna = "Nacimiento" });
				listaComunas.Add(new Comunas { IdComuna = 136, NombreComuna = "Lebu" });
				listaComunas.Add(new Comunas { IdComuna = 137, NombreComuna = "Calera de Tango" });
				listaComunas.Add(new Comunas { IdComuna = 138, NombreComuna = "Mostazal" });
				listaComunas.Add(new Comunas { IdComuna = 139, NombreComuna = "Tocopilla" });
				listaComunas.Add(new Comunas { IdComuna = 140, NombreComuna = "Pitrufquén" });
				listaComunas.Add(new Comunas { IdComuna = 141, NombreComuna = "Las Cabras" });
				listaComunas.Add(new Comunas { IdComuna = 142, NombreComuna = "Llaillay" });
				listaComunas.Add(new Comunas { IdComuna = 143, NombreComuna = "Freire" });
				listaComunas.Add(new Comunas { IdComuna = 144, NombreComuna = "Collipulli" });
				listaComunas.Add(new Comunas { IdComuna = 145, NombreComuna = "Carahue" });
				listaComunas.Add(new Comunas { IdComuna = 146, NombreComuna = "Hualqui" });
				listaComunas.Add(new Comunas { IdComuna = 147, NombreComuna = "Aysén" });
				listaComunas.Add(new Comunas { IdComuna = 148, NombreComuna = "Loncoche" });
				listaComunas.Add(new Comunas { IdComuna = 149, NombreComuna = "Cartagena" });
				listaComunas.Add(new Comunas { IdComuna = 150, NombreComuna = "Laja" });
				listaComunas.Add(new Comunas { IdComuna = 151, NombreComuna = "Nogales" });
				listaComunas.Add(new Comunas { IdComuna = 152, NombreComuna = "La Cruz" });
				listaComunas.Add(new Comunas { IdComuna = 153, NombreComuna = "Bulnes" });
				listaComunas.Add(new Comunas { IdComuna = 154, NombreComuna = "Natales" });
				listaComunas.Add(new Comunas { IdComuna = 155, NombreComuna = "Los Vilos" });
				listaComunas.Add(new Comunas { IdComuna = 156, NombreComuna = "Mariquina" });
				listaComunas.Add(new Comunas { IdComuna = 157, NombreComuna = "Yumbel" });
				listaComunas.Add(new Comunas { IdComuna = 158, NombreComuna = "Los Alamos" });
				listaComunas.Add(new Comunas { IdComuna = 159, NombreComuna = "Doñihue" });
				listaComunas.Add(new Comunas { IdComuna = 160, NombreComuna = "Colbún" });
				listaComunas.Add(new Comunas { IdComuna = 161, NombreComuna = "Purranque" });
				listaComunas.Add(new Comunas { IdComuna = 162, NombreComuna = "Paillaco" });
				listaComunas.Add(new Comunas { IdComuna = 163, NombreComuna = "Retiro" });
				listaComunas.Add(new Comunas { IdComuna = 164, NombreComuna = "Pichidehua" });
				listaComunas.Add(new Comunas { IdComuna = 165, NombreComuna = "Los Lagos" });
				listaComunas.Add(new Comunas { IdComuna = 166, NombreComuna = "Coltauco" });
				listaComunas.Add(new Comunas { IdComuna = 167, NombreComuna = "Cabildo" });
				listaComunas.Add(new Comunas { IdComuna = 168, NombreComuna = "Til Til" });
				listaComunas.Add(new Comunas { IdComuna = 169, NombreComuna = "San Esteban" });
				listaComunas.Add(new Comunas { IdComuna = 170, NombreComuna = "Traigen" });
				listaComunas.Add(new Comunas { IdComuna = 171, NombreComuna = "Puchuncaví" });
				listaComunas.Add(new Comunas { IdComuna = 172, NombreComuna = "Sagrada Familia" });
				listaComunas.Add(new Comunas { IdComuna = 173, NombreComuna = "Frutillar" });
				listaComunas.Add(new Comunas { IdComuna = 174, NombreComuna = "San José de Maipo" });
				listaComunas.Add(new Comunas { IdComuna = 175, NombreComuna = "Yerbas Buenas" });
				listaComunas.Add(new Comunas { IdComuna = 176, NombreComuna = "Hijuelas" });
				listaComunas.Add(new Comunas { IdComuna = 177, NombreComuna = "Nancahua" });
				listaComunas.Add(new Comunas { IdComuna = 178, NombreComuna = "Yungay" });
				listaComunas.Add(new Comunas { IdComuna = 179, NombreComuna = "Caldera" });
				listaComunas.Add(new Comunas { IdComuna = 180, NombreComuna = "Llanquihue" });
				listaComunas.Add(new Comunas { IdComuna = 181, NombreComuna = "Cunco" });
				listaComunas.Add(new Comunas { IdComuna = 182, NombreComuna = "Olmué" });
				listaComunas.Add(new Comunas { IdComuna = 183, NombreComuna = "Quillón" });
				listaComunas.Add(new Comunas { IdComuna = 184, NombreComuna = "Curacautín" });
				listaComunas.Add(new Comunas { IdComuna = 185, NombreComuna = "Los Mermos" });
				listaComunas.Add(new Comunas { IdComuna = 186, NombreComuna = "Putaendo" });
				listaComunas.Add(new Comunas { IdComuna = 187, NombreComuna = "Lanco" });
				listaComunas.Add(new Comunas { IdComuna = 188, NombreComuna = "Pichilemu" });
				listaComunas.Add(new Comunas { IdComuna = 189, NombreComuna = "Villa Alegre" });
				listaComunas.Add(new Comunas { IdComuna = 190, NombreComuna = "San Ignacio" });
				listaComunas.Add(new Comunas { IdComuna = 191, NombreComuna = "Coelemu" });
				listaComunas.Add(new Comunas { IdComuna = 192, NombreComuna = "El Quisco" });
				listaComunas.Add(new Comunas { IdComuna = 193, NombreComuna = "Pozo Almonte" });
				listaComunas.Add(new Comunas { IdComuna = 194, NombreComuna = "Santa Maria" });
				listaComunas.Add(new Comunas { IdComuna = 195, NombreComuna = "Romeral" });
				listaComunas.Add(new Comunas { IdComuna = 196, NombreComuna = "Teodoro Schmidt" });
				listaComunas.Add(new Comunas { IdComuna = 197, NombreComuna = "Chépica" });
				listaComunas.Add(new Comunas { IdComuna = 198, NombreComuna = "Chonchi" });
				listaComunas.Add(new Comunas { IdComuna = 199, NombreComuna = "Calle Larga" });
				listaComunas.Add(new Comunas { IdComuna = 200, NombreComuna = "Futrono" });
				listaComunas.Add(new Comunas { IdComuna = 201, NombreComuna = "Gorbea" });
				listaComunas.Add(new Comunas { IdComuna = 202, NombreComuna = "Peumo" });
				listaComunas.Add(new Comunas { IdComuna = 203, NombreComuna = "Maullín" });
				listaComunas.Add(new Comunas { IdComuna = 204, NombreComuna = "Tucapel" });
				listaComunas.Add(new Comunas { IdComuna = 205, NombreComuna = "Rio Negro" });
				listaComunas.Add(new Comunas { IdComuna = 206, NombreComuna = "Tierra Amarilla" });
				listaComunas.Add(new Comunas { IdComuna = 207, NombreComuna = "Catemu" });
				listaComunas.Add(new Comunas { IdComuna = 208, NombreComuna = "Diego de Almagro" });
				listaComunas.Add(new Comunas { IdComuna = 209, NombreComuna = "Rio Claro" });
				listaComunas.Add(new Comunas { IdComuna = 210, NombreComuna = "Algarrobo" });
				listaComunas.Add(new Comunas { IdComuna = 211, NombreComuna = "Santa Barbara" });
				listaComunas.Add(new Comunas { IdComuna = 212, NombreComuna = "Dalcahue" });
				listaComunas.Add(new Comunas { IdComuna = 213, NombreComuna = "Santa Juana" });
				listaComunas.Add(new Comunas { IdComuna = 214, NombreComuna = "Olivar" });
				listaComunas.Add(new Comunas { IdComuna = 215, NombreComuna = "Maria Pinto" });
				listaComunas.Add(new Comunas { IdComuna = 216, NombreComuna = "Mejillones" });
				listaComunas.Add(new Comunas { IdComuna = 217, NombreComuna = "Malloa" });
				listaComunas.Add(new Comunas { IdComuna = 218, NombreComuna = "Combarbalá" });
				listaComunas.Add(new Comunas { IdComuna = 219, NombreComuna = "Tal Tal" });
				listaComunas.Add(new Comunas { IdComuna = 220, NombreComuna = "El Tabo" });
				listaComunas.Add(new Comunas { IdComuna = 221, NombreComuna = "Quinta de Tiltoco" });
				listaComunas.Add(new Comunas { IdComuna = 222, NombreComuna = "Codehua" });
				listaComunas.Add(new Comunas { IdComuna = 223, NombreComuna = "Palmilla" });
				listaComunas.Add(new Comunas { IdComuna = 224, NombreComuna = "Saavedra" });
				listaComunas.Add(new Comunas { IdComuna = 225, NombreComuna = "Fresia" });
				listaComunas.Add(new Comunas { IdComuna = 226, NombreComuna = "Chañaral" });
				listaComunas.Add(new Comunas { IdComuna = 227, NombreComuna = "El Carmen" });
				listaComunas.Add(new Comunas { IdComuna = 228, NombreComuna = "Galvarino" });
				listaComunas.Add(new Comunas { IdComuna = 229, NombreComuna = "Puren" });
				listaComunas.Add(new Comunas { IdComuna = 230, NombreComuna = "Puyehue" });
				listaComunas.Add(new Comunas { IdComuna = 231, NombreComuna = "Cholchol" });
				listaComunas.Add(new Comunas { IdComuna = 232, NombreComuna = "San Nicolás" });
				listaComunas.Add(new Comunas { IdComuna = 233, NombreComuna = "Quirihue" });
				listaComunas.Add(new Comunas { IdComuna = 234, NombreComuna = "Ñiquén" });
				listaComunas.Add(new Comunas { IdComuna = 235, NombreComuna = "Andacollo" });
				listaComunas.Add(new Comunas { IdComuna = 236, NombreComuna = "Peralillo" });
				listaComunas.Add(new Comunas { IdComuna = 237, NombreComuna = "San Pedro de Atacama" });
				listaComunas.Add(new Comunas { IdComuna = 238, NombreComuna = "Punitaqui" });
				listaComunas.Add(new Comunas { IdComuna = 239, NombreComuna = "Santo Domingo" });
				listaComunas.Add(new Comunas { IdComuna = 240, NombreComuna = "Pinto" });
				listaComunas.Add(new Comunas { IdComuna = 241, NombreComuna = "Florida" });
				listaComunas.Add(new Comunas { IdComuna = 242, NombreComuna = "Rauco" });
				listaComunas.Add(new Comunas { IdComuna = 243, NombreComuna = "Tirúa" });
				listaComunas.Add(new Comunas { IdComuna = 244, NombreComuna = "Loquimay" });
				listaComunas.Add(new Comunas { IdComuna = 245, NombreComuna = "Renaico" });
				listaComunas.Add(new Comunas { IdComuna = 246, NombreComuna = "Rinconada" });
				listaComunas.Add(new Comunas { IdComuna = 247, NombreComuna = "Sierra Gorda" });
				listaComunas.Add(new Comunas { IdComuna = 248, NombreComuna = "Huasco" });
				listaComunas.Add(new Comunas { IdComuna = 249, NombreComuna = "San Pablo" });
				listaComunas.Add(new Comunas { IdComuna = 250, NombreComuna = "Lago Ranco" });
				listaComunas.Add(new Comunas { IdComuna = 251, NombreComuna = "Petorca" });
				listaComunas.Add(new Comunas { IdComuna = 252, NombreComuna = "Negrete" });
				listaComunas.Add(new Comunas { IdComuna = 253, NombreComuna = "San Pedro" });
				listaComunas.Add(new Comunas { IdComuna = 254, NombreComuna = "Toltén" });
				listaComunas.Add(new Comunas { IdComuna = 255, NombreComuna = "Hualañe" });
				listaComunas.Add(new Comunas { IdComuna = 256, NombreComuna = "Quilleco" });
				listaComunas.Add(new Comunas { IdComuna = 257, NombreComuna = "Lumaco" });
				listaComunas.Add(new Comunas { IdComuna = 258, NombreComuna = "Curepto" });
				listaComunas.Add(new Comunas { IdComuna = 259, NombreComuna = "Pica" });
				listaComunas.Add(new Comunas { IdComuna = 260, NombreComuna = "San Rafaél" });
				listaComunas.Add(new Comunas { IdComuna = 261, NombreComuna = "Canela" });
				listaComunas.Add(new Comunas { IdComuna = 262, NombreComuna = "Puerto Octay" });
				listaComunas.Add(new Comunas { IdComuna = 263, NombreComuna = "Hualaihué" });
				listaComunas.Add(new Comunas { IdComuna = 264, NombreComuna = "Chanco" });
				listaComunas.Add(new Comunas { IdComuna = 265, NombreComuna = "Placilla" });
				listaComunas.Add(new Comunas { IdComuna = 266, NombreComuna = "Pemuco" });
				listaComunas.Add(new Comunas { IdComuna = 267, NombreComuna = "Pelarco" });
				listaComunas.Add(new Comunas { IdComuna = 268, NombreComuna = "Quemchi" });
				listaComunas.Add(new Comunas { IdComuna = 269, NombreComuna = "Pencahue" });
				listaComunas.Add(new Comunas { IdComuna = 270, NombreComuna = "Quinchao" });
				listaComunas.Add(new Comunas { IdComuna = 271, NombreComuna = "Isla de Pascua" });
				listaComunas.Add(new Comunas { IdComuna = 272, NombreComuna = "Ercilla" });
				listaComunas.Add(new Comunas { IdComuna = 273, NombreComuna = "Pelluhue" });
				listaComunas.Add(new Comunas { IdComuna = 274, NombreComuna = "San Juan de La Costa" });
				listaComunas.Add(new Comunas { IdComuna = 275, NombreComuna = "Curarrehue" });
				listaComunas.Add(new Comunas { IdComuna = 276, NombreComuna = "Coinco" });
				listaComunas.Add(new Comunas { IdComuna = 277, NombreComuna = "Zapallar" });
				listaComunas.Add(new Comunas { IdComuna = 278, NombreComuna = "Marchihué" });
				listaComunas.Add(new Comunas { IdComuna = 279, NombreComuna = "Panquehue" });
				listaComunas.Add(new Comunas { IdComuna = 280, NombreComuna = "Los Sauces" });
				listaComunas.Add(new Comunas { IdComuna = 281, NombreComuna = "Mafil" });
				listaComunas.Add(new Comunas { IdComuna = 282, NombreComuna = "Freirina" });
				listaComunas.Add(new Comunas { IdComuna = 283, NombreComuna = "Perquenco" });
				listaComunas.Add(new Comunas { IdComuna = 284, NombreComuna = "Lolol" });
				listaComunas.Add(new Comunas { IdComuna = 285, NombreComuna = "Porvenir" });
				listaComunas.Add(new Comunas { IdComuna = 286, NombreComuna = "Licantén" });
				listaComunas.Add(new Comunas { IdComuna = 287, NombreComuna = "Navidad" });
				listaComunas.Add(new Comunas { IdComuna = 288, NombreComuna = "Cisnes" });
				listaComunas.Add(new Comunas { IdComuna = 289, NombreComuna = "María Elena" });
				listaComunas.Add(new Comunas { IdComuna = 290, NombreComuna = "Alhué" });
				listaComunas.Add(new Comunas { IdComuna = 291, NombreComuna = "Papudo" });
				listaComunas.Add(new Comunas { IdComuna = 292, NombreComuna = "Litueche" });
				listaComunas.Add(new Comunas { IdComuna = 293, NombreComuna = "Paredones" });
				listaComunas.Add(new Comunas { IdComuna = 294, NombreComuna = "Milipeuco" });
				listaComunas.Add(new Comunas { IdComuna = 295, NombreComuna = "Contulmo" });
				listaComunas.Add(new Comunas { IdComuna = 296, NombreComuna = "Alto BioBío" });
				listaComunas.Add(new Comunas { IdComuna = 297, NombreComuna = "Ránquil" });
				listaComunas.Add(new Comunas { IdComuna = 298, NombreComuna = "Treguaco" });
				listaComunas.Add(new Comunas { IdComuna = 299, NombreComuna = "Queilén" });
				listaComunas.Add(new Comunas { IdComuna = 300, NombreComuna = "Corral" });
				listaComunas.Add(new Comunas { IdComuna = 301, NombreComuna = "Alto del Carmen" });
				listaComunas.Add(new Comunas { IdComuna = 302, NombreComuna = "Ninhue" });
				listaComunas.Add(new Comunas { IdComuna = 303, NombreComuna = "Chaitén" });
				listaComunas.Add(new Comunas { IdComuna = 304, NombreComuna = "Cobquecura" });
				listaComunas.Add(new Comunas { IdComuna = 305, NombreComuna = "Chile Chico" });
				listaComunas.Add(new Comunas { IdComuna = 306, NombreComuna = "Portezuelo" });
				listaComunas.Add(new Comunas { IdComuna = 307, NombreComuna = "Paihuano" });
				listaComunas.Add(new Comunas { IdComuna = 308, NombreComuna = "Vichuquén" });
				listaComunas.Add(new Comunas { IdComuna = 309, NombreComuna = "San Fabián" });
				listaComunas.Add(new Comunas { IdComuna = 310, NombreComuna = "Rio Hurtado" });
				listaComunas.Add(new Comunas { IdComuna = 311, NombreComuna = "La Higuera" });
				listaComunas.Add(new Comunas { IdComuna = 312, NombreComuna = "Empedrado" });
				listaComunas.Add(new Comunas { IdComuna = 313, NombreComuna = "Antauco" });
				listaComunas.Add(new Comunas { IdComuna = 314, NombreComuna = "Cochamó" });
				listaComunas.Add(new Comunas { IdComuna = 315, NombreComuna = "Quilaco" });
				listaComunas.Add(new Comunas { IdComuna = 316, NombreComuna = "Puqueldón" });
				listaComunas.Add(new Comunas { IdComuna = 317, NombreComuna = "Curaco de Veléz" });
				listaComunas.Add(new Comunas { IdComuna = 318, NombreComuna = "Cochrane" });
				listaComunas.Add(new Comunas { IdComuna = 319, NombreComuna = "Pumanque" });
				listaComunas.Add(new Comunas { IdComuna = 320, NombreComuna = "San Rosendo" });
				listaComunas.Add(new Comunas { IdComuna = 321, NombreComuna = "La Estrella" });
				listaComunas.Add(new Comunas { IdComuna = 322, NombreComuna = "Putre" });
				listaComunas.Add(new Comunas { IdComuna = 323, NombreComuna = "Huara" });
				listaComunas.Add(new Comunas { IdComuna = 324, NombreComuna = "Rio Ibáñez" });
				listaComunas.Add(new Comunas { IdComuna = 325, NombreComuna = "Futaleufú" });
				listaComunas.Add(new Comunas { IdComuna = 326, NombreComuna = "Cabo de Hornos" });
				listaComunas.Add(new Comunas { IdComuna = 327, NombreComuna = "Guaticas" });
				listaComunas.Add(new Comunas { IdComuna = 328, NombreComuna = "Colchane" });
				listaComunas.Add(new Comunas { IdComuna = 329, NombreComuna = "Palena" });
				listaComunas.Add(new Comunas { IdComuna = 330, NombreComuna = "Camarones" });
				listaComunas.Add(new Comunas { IdComuna = 331, NombreComuna = "Camiña" });
				listaComunas.Add(new Comunas { IdComuna = 332, NombreComuna = "Torres del Paine" });
				listaComunas.Add(new Comunas { IdComuna = 333, NombreComuna = "Primavera" });
				listaComunas.Add(new Comunas { IdComuna = 334, NombreComuna = "Juan Fernandez" });
				listaComunas.Add(new Comunas { IdComuna = 335, NombreComuna = "Lago Verde" });
				listaComunas.Add(new Comunas { IdComuna = 336, NombreComuna = "San Gregorio" });
				listaComunas.Add(new Comunas { IdComuna = 337, NombreComuna = "General Lagos" });
				listaComunas.Add(new Comunas { IdComuna = 338, NombreComuna = "O'Higgins" });
				listaComunas.Add(new Comunas { IdComuna = 339, NombreComuna = "Rio Verde" });
				listaComunas.Add(new Comunas { IdComuna = 340, NombreComuna = "Tortel" });
				listaComunas.Add(new Comunas { IdComuna = 341, NombreComuna = "Timaukel" });
				listaComunas.Add(new Comunas { IdComuna = 342, NombreComuna = "Ollagüe" });
				listaComunas.Add(new Comunas { IdComuna = 343, NombreComuna = "Laguna Blanca" });
				listaComunas.Add(new Comunas { IdComuna = 344, NombreComuna = "Antártica" });
			


				this.cboComuna.DisplayMemberPath = "NombreComuna";
				this.cboComuna.SelectedValuePath = "IdComuna";
				this.cboComuna.ItemsSource = listaComunas;
			}


        #endregion

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				conexion.Open();
				OracleCommand comando = new OracleCommand("sp_agregarCliente", conexion);
				comando.CommandType = System.Data.CommandType.StoredProcedure;
				comando.Parameters.Add("newidCliente", OracleType.Number).Value = int.Parse(txtIdCliente.Text);
				comando.Parameters.Add("newrut", OracleType.NVarChar).Value = txtRutCliente.Text;
				comando.Parameters.Add("newnombre", OracleType.NVarChar).Value = txtNombreCliente.Text;
				comando.Parameters.Add("newapellido", OracleType.NVarChar).Value = txtApellidoCliente.Text;
				comando.Parameters.Add("newemail", OracleType.VarChar).Value = txtEmailCliente.Text;
				comando.Parameters.Add("newtelefono", OracleType.NVarChar).Value = txtTelefonoCliente.Text;
				comando.Parameters.Add("newfechanacimiento", OracleType.DateTime).Value = dtpFechaNacimientoCliente.ToString();
				comando.Parameters.Add("newdirreccion", OracleType.NVarChar).Value = txtDireccionCliente.Text;
				comando.Parameters.Add("newregion", OracleType.NVarChar).Value = cboRegion.ToString();
				comando.Parameters.Add("newcomuna", OracleType.NVarChar).Value = cboComuna.ToString();
				comando.Parameters.Add("newliquidaciones", OracleType.VarChar).Value = txtLiquidacionesCliente.Text;
				comando.Parameters.Add("newafp", OracleType.VarChar).Value = txtCertAfpCliente.Text;
				comando.Parameters.Add("newsalud", OracleType.VarChar).Value = txtCertSaludCliente.Text;
				comando.Parameters.Add("newfiniquitos", OracleType.VarChar).Value = txtFiniquitos.Text;


				comando.ExecuteNonQuery();
				MessageBox.Show("Cliente agregado");

			}
			catch (Exception ex)

			{
				Console.Out.WriteLine(ex.ToString());

				MessageBox.Show("Cliente no agregado");
			}
			conexion.Close();
		}

        private void btnModificarCliente_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				conexion.Open();
				OracleCommand comadno = new OracleCommand("SP_EDITAR", conexion);
				comadno.CommandType = System.Data.CommandType.StoredProcedure;
				comadno.Parameters.Add("editidCliente", OracleType.Number).Value = int.Parse(txtIdCliente.Text);
				comadno.Parameters.Add("editrut", OracleType.NVarChar).Value = txtRutCliente.Text;
				comadno.Parameters.Add("editnombre", OracleType.NVarChar).Value = txtNombreCliente.Text;
				comadno.Parameters.Add("editapellido", OracleType.NVarChar).Value = txtApellidoCliente.Text;
				comadno.Parameters.Add("editemail", OracleType.VarChar).Value = txtEmailCliente.Text;
				comadno.Parameters.Add("edittelefono", OracleType.NVarChar).Value = txtTelefonoCliente.Text;
				comadno.Parameters.Add("editfechanacimiento", OracleType.DateTime).Value = dtpFechaNacimientoCliente.ToString();
				comadno.Parameters.Add("editdirreccion", OracleType.NVarChar).Value = txtDireccionCliente.Text;
				comadno.Parameters.Add("editregion", OracleType.NVarChar).Value = cboRegion.ToString(); 
				comadno.Parameters.Add("editcomuna", OracleType.NVarChar).Value = cboComuna.ToString(); 
				comadno.ExecuteNonQuery();
				MessageBox.Show("cliente modificado");
			}
			catch
			{
				MessageBox.Show("cliente no modificado");
			}
			conexion.Close();
		}

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				conexion.Open();
				OracleCommand comadno = new OracleCommand("SP_ELIMINAR", conexion);
				comadno.CommandType = System.Data.CommandType.StoredProcedure;
				comadno.Parameters.Add("deleteidCliente", OracleType.Number).Value = Convert.ToInt32(txtIdCliente.Text);
				comadno.ExecuteNonQuery();
				MessageBox.Show("Cliente eliminado");
			}
			catch
			{
				MessageBox.Show("Cliente no eliminado");
			}
			conexion.Close();
		}

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
			conexion.Open();

			OracleCommand comadno = new OracleCommand("SP_LISTAR", conexion);
			comadno.CommandType = System.Data.CommandType.StoredProcedure;
			comadno.Parameters.Add("registro", OracleType.Cursor).Direction = ParameterDirection.Output;

			OracleDataAdapter adaptador = new OracleDataAdapter();
			adaptador.SelectCommand = comadno;
			DataSet tabla = new DataSet();
			adaptador.Fill(tabla);



			dgdDataGrid.ItemsSource = tabla.Tables[0].DefaultView;
			//dgdDataGrid.DataSource = tabla;

			conexion.Close();

		}
	}
}
