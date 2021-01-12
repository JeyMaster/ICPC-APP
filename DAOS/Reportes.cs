using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace DAOS
{
	public class Reportes
	{
		public DataSet EQUIPOS_MIEMBRO(String email,int anio)
		{
			DataSet ds = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "select e.nombre Equipo,"+ 
					"("+
						"select i.nombreCompleto from instituciones i where i.idInstitucion = e.idInstitucion"+
					") Institucion,"+
					"("+
						"select c.nombre from detalle_concurso dc join concursos c on c.idConcurso = dc.idConcurso "+
						"where dc.idEquipo = e.idEquipo"+
					") Concurso," +
					"(" +
						"select s.nombre from detalle_concurso dc join concursos c " +
						"on c.idConcurso = dc.idConcurso join sedes s on " +
						"c.idSede = s.idSede where dc.idEquipo = e.idEquipo" +

					") Sede ,e.idEquipo " +
					 "from equipos e join detalle_equipo de on de.idEquipo = e.idEquipo where de.email = @email " +
					 "and year(ciclo)=@anio";

				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
				cmd.Parameters.AddWithValue("@email",email);
				cmd.Parameters.AddWithValue("anio",anio);

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				da.Fill(ds);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ds = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ds;
		}

		public DataSet EQUIPO_MIEMBROS(int idEquipo)
		{
			DataSet ds = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "select concat(i.nombre,' ',i.apellido)" +
					" Nombre, de.email Email ,de.rol Rol from detalle_equipo de " +
					"join miembros i on de.email=i.email where idEquipo= @id";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id", idEquipo);
				

				MySqlDataAdapter da = new MySqlDataAdapter(cmd);
			
				ds = new DataSet();
				da.Fill(ds);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ds = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ds;
		}

		public DataSet EQUIPO_SEDE(int year)
		{
			DataSet ds = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "select" +
				"(" +
					"select s.nombre from detalle_concurso dc join concursos c on c.idConcurso = dc.idConcurso " +
					"join sedes s on c.idSede = s.idSede where dc.idEquipo = e.idEquipo" +
				") Sede, e.nombre Equipo," +
				"(" +
					"select count(de.email) from detalle_equipo de where de.idEquipo = e.idEquipo and(de.rol = 3 or de.rol = 4)" +
				") Concursantes," +
				"(" +
					"select count(de.email) from detalle_equipo de where de.idEquipo = e.idEquipo and(de.rol = 2)" +
				") `Co - Coaches`,e.Ciclo `Fecha de Registro` from equipos e where year(ciclo) = @year";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@year", year);


				MySqlDataAdapter da = new MySqlDataAdapter(cmd);

				ds = new DataSet();
				da.Fill(ds);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ds = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ds;
		}

		public DataSet REGION(int year)
		{
			DataSet ds = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "Select r.nombre Región, "+
				 "(" +
					"select count(*) from sedes s where s.idRegion = r.idRegion" +
				 ")Sedes," +
				"(" +
					"select count(dc.idEquipo) from sedes s join concursos c on s.idSede = c.idSede " +
					"join detalle_concurso dc on c.idConcurso = dc.idConcurso join equipos e on dc.idequipo = e.idequipo " +
					"where s.idRegion = r.idRegion and year(e.ciclo)= @year" +
				")`Equipos registrados` from regiones r";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@year", year);


				MySqlDataAdapter da = new MySqlDataAdapter(cmd);

				ds = new DataSet();
				da.Fill(ds);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ds = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ds;
		}

		public DataSet INSTITUCION(int year)
		{
			DataSet ds = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "select"+
				"(" +
					"select r.nombre from regiones r where r.idRegion = i.idRegion" +
				")Region,i.nombreCompleto Universidad," +
				"(" +
					"select count(*) from equipos e where e.idInstitucion = i.idInstitucion and year(e.ciclo) = @year" +
				") `EQUIPOS REGISTRADOS` from instituciones i having `EQUIPOS REGISTRADOS` > 0";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@year", year);


				MySqlDataAdapter da = new MySqlDataAdapter(cmd);

				ds = new DataSet();
				da.Fill(ds);

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ds = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ds;
		}
	}
}
