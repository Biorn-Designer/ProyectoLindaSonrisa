using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindaSonrisa.Business
{
	public class Servicios
	{
		private int _idServicio;
		private string _nombreServicio;

		public string NombreServicio
		{
			get { return _nombreServicio; }
			set { _nombreServicio = value; }
		}


		public int IdServicio
		{
			get { return _idServicio; }
			set { _idServicio = value; }
		}

	}
}
