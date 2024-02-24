using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindaSonrisa.Business
{
	public class Regiones
	{

		private int _idRegion;
		private string _nombreRegion;

		public int IdRegion
		{
			get { return _idRegion; }
			set { _idRegion = value; }
		}

		public string NombreRegion
		{
			get { return _nombreRegion; }
			set { _nombreRegion = value; }
		}


	}
}
