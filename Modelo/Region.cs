using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
	public class Region
	{
		public int IdRegion { get; set; }
		public String Nombre { get; set; }

		override
		public String ToString()
		{
			return Nombre;
		}
        
        
	}
}
