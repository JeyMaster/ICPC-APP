using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
	public class Concurso
	{
		public int IdConcurso { get; set; }
		public int IdSede { get; set; }
        public String NombreSede { get; set; }
        public String Titulo { get; set; }
		public String Nombre { get; set; }
		public String Email { get; set; }
		public String Locacion { get; set; }
		public String InfoFacturacion { get; set; }
        

		override
		public string ToString()
		{
			return Nombre;
		}
	}
}
