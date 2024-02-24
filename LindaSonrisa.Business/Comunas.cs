using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindaSonrisa.Business
{
	public class Comunas
	{
		private int _idComuna;
		private string _nombreComuna;

		public string NombreComuna
		{
			get { return _nombreComuna; }
			set { _nombreComuna = value; }
		}

		public int IdComuna
		{
			get { return _idComuna; }
			set { _idComuna = value; }
		}

	}
}
