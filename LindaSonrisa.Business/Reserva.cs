using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindaSonrisa.Business
{
	public class Reserva
	{
		#region Variables
			private int _idReserva;
			private int _idCliente;
			private DateTime _fechaReserva;
			private int _idModulo;
			private string _estado;
		#endregion

		#region Propiedades
			public int IdReserva
			{
				get { return _idReserva; }
				set { _idReserva = value; }
			}

		

			public int IdCliente
			{
				get { return _idCliente; }
				set { _idCliente = value; }
			}

		

			public DateTime FechaReserva
			{
				get { return _fechaReserva; }
				set { _fechaReserva = value; }
			}

		

			public int IdModulo
			{
				get { return _idModulo; }
				set { _idModulo = value; }
			}

		

			public string Estado
			{
				get { return _estado; }
				set { _estado = value; }
			}

		#endregion

		#region Constructor
			public Reserva()
			{
				_idReserva = 0;
				_idCliente = 0;
				_fechaReserva = DateTime.Now;
				_idModulo = 0;
				_estado = "";
			}

		#endregion

	}
}
