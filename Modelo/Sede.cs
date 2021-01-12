using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
	public class Sede
	{
		public int IdSede { get; set; }
		public String Nombre { get; set; }
		public int IdRegion { get; set; }
        public String NombreRegion { get; set; }

        override
		public string ToString()
		{
			return Nombre;
		}
	}
}
