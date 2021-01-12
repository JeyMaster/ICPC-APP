using System;

namespace Modelo
{
	public class Miembro
	{

		public Miembro() { }

		/// <summary>
		/// Constructor para inicilizar un miembro en su registro
		/// </summary>
		/// <param name="email">Email del miembro</param>
		/// <param name="nombre">Nombre del miembro</param>
		/// <param name="apellido">Apellido del miembro</param>
		/// <param name="contrasenia">Contraseña del miembro</param>
		public Miembro(String email,String nombre,String apellido,String contrasenia)
		{
			Email = email;
			Nombre = nombre;
			Apellido = apellido;
			Contrasenia = contrasenia;
		}


		public String Email { get; set; }
		public String Contrasenia { get; set; }
		public String Titulo { get; set; }
		public String Nombre { get; set; }
		public String Apellido { get; set; }
		public String NombreDistintivo { get; set; }
		public String NombreDeCertificado { get; set; }
		public char Sexo { get; set; }
		public String TallaDeCamisa { get; set; }
		public DateTime FechaDeNacimiento { get; set; }
		public String CiudadDeOrigen { get; set; }
		public String EstadoDeOrigen { get; set; }
		public String PaisDeOrigen { get; set; }
		public String PaisDeResidencia { get; set; }
		public String Ocupacion { get; set; }
		public String InstitutoEmpleoCompania { get; set; }
		public String NecesidadesEspeciales { get; set; }
		public String EmailSecundario { get; set; }

		override
		public String ToString()
		{
			return Email;
		}
	}
}
