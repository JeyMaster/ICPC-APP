using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;
namespace DAOS
{
	public class DaoEquipo
	{
		/// <summary>
		/// Inserta un equipo en la base de datos
		/// </summary>
		/// <param name="objEquipo">Equipo a insetar</param>
		/// <returns>Valor de la llave primaria que le pertenece</returns>
		public int INSERT(Equipo objEquipo)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "INSERT INTO EQUIPOS(nombre,idInstitucion,ciclo) " +
					"VALUES(@nombre,@idInstitucion,@ciclo)";
				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
				cmd.Parameters.AddWithValue("@nombre",objEquipo.Nombre);
				cmd.Parameters.AddWithValue("@idInstitucion",objEquipo.IdInstitucion);
				cmd.Parameters.AddWithValue("@ciclo",objEquipo.Ciclo);

				cmd.ExecuteNonQuery();
				done = (int)cmd.LastInsertedId;

			}
			catch (MySqlException ex)
			{
				done = 0;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return done;
		}

		/// <summary>
		/// Consulta los equipos de la base de datos
		/// </summary>
		/// <returns>La lista de equipos</returns>
		public List<Equipo> SELECT()
		{
			MySqlConnection conn = Connection.Conn();
			List<Equipo> ltsEquipos = null;

			try
			{
				String cmdStr ="SELECT * FROM EQUIPOS";
				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
				MySqlDataReader dr = cmd.ExecuteReader();
				ltsEquipos = new List<Equipo>();
				while (dr.Read())
				{
					Equipo objEquipo = new Equipo();

					objEquipo.IdEquipo = int.Parse(dr["idEquipo"].ToString());
					objEquipo.IdInstitucion = int.Parse(dr["idInstitucion"].ToString());
					objEquipo.Ciclo = dr.GetDateTime("ciclo");
					objEquipo.Nombre = dr["nombre"].ToString();

					ltsEquipos.Add(objEquipo);
				}
			}
			catch (MySqlException ex)
			{
				ltsEquipos = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return ltsEquipos;
		}

		/// <summary>
		/// Consulta un equipo de la base de datos
		/// </summary>
		/// <param name="idEquipo">Llave primaria del equipo</param>
		/// <returns>Un equipo</returns>
		public Equipo SELECT(int idEquipo)
		{
			MySqlConnection conn = Connection.Conn();
			Equipo objEquipo = null;

			try
			{
				String cmdStr = "SELECT * FROM EQUIPOS WHERE idEquipo=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id", idEquipo);
				MySqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					objEquipo = new Equipo();

					objEquipo.IdEquipo = int.Parse(dr["idEquipo"].ToString());
					objEquipo.IdInstitucion = int.Parse(dr["idInstitucion"].ToString());
					objEquipo.Ciclo = dr.GetDateTime("ciclo");
					objEquipo.Nombre = dr["nombre"].ToString();
				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				objEquipo = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return objEquipo;
		}

		/// <summary>
		/// Actualiza un equipo en la base de datos
		/// </summary>
		/// <param name="objEquipo">Llave primaria del equipo</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Equipo objEquipo)
		{
			MySqlConnection conn = Connection.Conn();
			bool done = false;

			try
			{
				String cmdStr = "UPDATE EQUIPOS SET nombre=@nombre,idInstitucion=@idInstitucion,ciclo=@ciclo" +
					" WHERE idEquipo=@idEquipo";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idEquipo", objEquipo.IdEquipo);
				cmd.Parameters.AddWithValue("@nombre", objEquipo.Nombre);
				cmd.Parameters.AddWithValue("@idInstitucion", objEquipo.IdInstitucion);
				cmd.Parameters.AddWithValue("@ciclo", objEquipo.Ciclo);

				cmd.ExecuteNonQuery();
				done = true;
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = false;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}
	}
}
