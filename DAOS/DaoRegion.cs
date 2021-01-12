using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace DAOS
{
	public class DaoRegion
	{
		/// <summary>
		/// Inserta una region en la base de datos
		/// </summary>
		/// <param name="objRegion">Objeto region a insertar</param>
		/// <returns>Retorna el valor de llave primaria que le pertenece</returns>
		public int INSERT(Region objRegion)
		{
			int done=0;
			MySqlConnection conn = Connection.Conn();
            MySqlCommand cmd=new MySqlCommand();

            try
			{
             
                cmd.Connection = conn;

                cmd.CommandText = "AgregarRegion";
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("nombre_region", objRegion.Nombre);
                cmd.ExecuteNonQuery();

            }
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = 0;
			}
			finally
			{
				conn.Close();
			}
			return done;
		}

		/// <summary>
		/// Consulta las regiones que existen en la base de datos
		/// </summary>
		/// <returns>List de Regiones</returns>
		public List<Region> SELECT()
		{
			List<Region> ltsRegiones=null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String strCmd = "SeleccionarRegiones";
				MySqlCommand cmd = new MySqlCommand(strCmd, conn);
				cmd.CommandType = CommandType.StoredProcedure;
				MySqlDataReader dr = cmd.ExecuteReader();
				ltsRegiones = new List<Region>();
				while (dr.Read())
				{
					Region objRegiones = new Region();
					objRegiones.IdRegion = int.Parse(dr["idRegion"].ToString());
					objRegiones.Nombre = (dr["nombre"].ToString());

					ltsRegiones.Add(objRegiones);

				}
			}
			catch (MySqlException ex)
			{
				ltsRegiones = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return ltsRegiones;
		}

		/// <summary>
		/// Consulta una region por medio de su llave primaria
		/// </summary>
		/// <param name="idRegion">Llave primaria de la region</param>
		/// <returns>Una region</returns>
		public Region SELECT(int idRegion)
		{
			
			MySqlConnection conn = Connection.Conn();
			Region objRegiones = null;
			try
			{
				String strCmd = "SeleccionarRegionesPorId";
				MySqlCommand cmd = new MySqlCommand(strCmd, conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("Id_Region", idRegion);
				MySqlDataReader dr = cmd.ExecuteReader();
		
				while (dr.Read())
				{
					objRegiones = new Region();
					objRegiones.IdRegion = int.Parse(dr["idRegion"].ToString());
					objRegiones.Nombre = (dr["nombre"].ToString());
				}
			}
			catch (MySqlException ex)
			{
				objRegiones = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
			return objRegiones;
		}

		/// <summary>
		/// Actualiza los valores de una region en la base de datos
		/// </summary>
		/// <param name="objRegion">Region a actualizar</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Region objRegion)
		{
			bool done = false;
			MySqlConnection conn = Connection.Conn();
			try
			{
				String strComm = "EditarRegiones";
				MySqlCommand cmd = new MySqlCommand(strComm, conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("Id_Region", objRegion.IdRegion);
				cmd.Parameters.AddWithValue("nombre_region", objRegion.Nombre);
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

		/// <summary>
		/// Elimina una region de la base de datos
		/// </summary>
		/// <param name="IdRegion">Id de la region</param>
		/// <returns>Booleano</returns>
		public bool DELETE(int IdRegion)
		{
			bool done = false;
			MySqlConnection conn = Connection.Conn();
			try
			{
				String strComm = "EliminarRegiones";
				MySqlCommand cmd = new MySqlCommand(strComm, conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("Id_Region", IdRegion);
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
			}
			return done;
		}

	}
}
