using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
	public class Institucion
	{
		public int IdInstitucion { get; set; }
        public int IdRegion { get; set; }
        public String NombreRegion { get; set; }
        public String NombreCompleto { get; set; }
		public String NombreCorto { get; set; }
		public String PaginaWeb { get; set; }
		public String GradoOfrecido { get; set; }
		public String CompaniaCalle { get; set; }
		public String Ciudad { get; set; }
		public String State { get; set; }
		public String LineaDeCalle_2 { get; set; }
		public String CodigoPostal { get; set; }
		public String Estado { get; set; }
		public String LineaDeCalle_3 { get; set; }

        

        override
		public string ToString()
		{
			return NombreCompleto;
		}
	}
}
