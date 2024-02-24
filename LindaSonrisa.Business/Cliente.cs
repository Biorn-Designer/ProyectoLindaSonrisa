using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindaSonrisa.Business
{
	public class Cliente
	{
		#region Variables
			private int _idCliente;
			private string _rut;
			private string _firstName;
			private string _lastName;
			private string _email;
			private string _telefono;
			private DateTime _fechaNacimiento;
			private string _direccion;
			private string _region;
			private string _comuna;
			private string _certificadoSalud;
			private string _liquidaciones;
			private string _certificadoAfp;
			private string _finiquitos;
		#endregion

		#region Propiedades

			public int IdCliente
			{
				get { return _idCliente; }
				set { _idCliente = value; }
			}

			public string Rut
			{
				get { return _rut; }
				set { _rut = value; }
			}

			public string FirstName
			{
				get { return _firstName; }
				set { _firstName = value; }
			}

			public string LastName
			{
				get { return _lastName; }
				set { _lastName = value; }
			}

			public string Email
			{
					get { return _email; }
					set { _email = value; }
			}

			public string Telefono
			{
				get { return _telefono; }
				set { _telefono = value; }
			}


			public DateTime FechaNacimiento
				{
					get { return _fechaNacimiento; }
					set { _fechaNacimiento = value; }
				}

			public string Direccion
			{
				get { return _direccion; }
				set { _direccion = value; }
			}
			public string Region
				{
					get { return _region; }
					set { _region = value; }
				}

			public string Comuna
			{
				get { return _comuna; }
				set { _comuna = value; }
			}

			public string Liquidaciones
			{
				get { return _liquidaciones; }
				set { _liquidaciones = value; }
			}

			public string CertificadoAfp
			{
				get { return _certificadoAfp; }
				set { _certificadoAfp = value; }
			}

			public string CertificadoSalud
			{
				get { return _certificadoSalud; }
				set { _certificadoSalud = value; }
			}

			public string Finiquitos
			{
				get { return _finiquitos; }
				set { _finiquitos = value; }
			}

		#endregion

		#region Constructor
			public Cliente()
			{
				_idCliente = 0;
				_rut = "";
				_firstName = "";
				_lastName = "";
				_email = "";
				_telefono = "";
				_fechaNacimiento = DateTime.Now;
				_direccion = "";
				_region = "";
				_comuna = "";
				_liquidaciones = "";
				_certificadoAfp = "";
				_certificadoSalud = "";
				_finiquitos = "";
			}
		#endregion


	}
}
