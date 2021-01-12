using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoConcurso
	{
        public List<Concurso> SELECT_ALL_JOIN()
        {
            List<Concurso> ltsConcursos = null;
            MySqlConnection conn = Connection.Conn();

            try
            {
                String cmdStr = "select c.idConcurso,c.idSede as CidSede,s.nombre as Snombre,c.titulo,c.nombre as Cnombre,c.email,c.locacion,c.infoFacturacion " +
                                "from concursos c join sedes s "+
                                "where c.idSede = s.idSede";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                ltsConcursos = new List<Concurso>();
                while (dr.Read())
                {
                    Concurso objConcurso = new Concurso();
                    objConcurso.IdConcurso = int.Parse(dr["idConcurso"].ToString());
                    objConcurso.IdSede = int.Parse(dr["CidSede"].ToString());
                    objConcurso.NombreSede = dr["Snombre"].ToString();
                    objConcurso.Titulo = dr["titulo"].ToString();
                    objConcurso.Locacion = dr["locacion"].ToString();
                    objConcurso.Nombre = dr["Cnombre"].ToString();
                    objConcurso.InfoFacturacion = dr["infoFacturacion"].ToString();
                    objConcurso.Email = dr["email"].ToString();

                    ltsConcursos.Add(objConcurso);
                }
            }
            catch (MySqlException ex)
            {
                ltsConcursos = null;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ltsConcursos;
        }
        /// <summary>
        /// Consulta todos los concursos de la tabla concursos
        /// </summary>
        /// <returns>Una lista de concursos</returns>
        public List<Concurso> SELECT_ALL()
        {
            List<Concurso> ltsConcursos = null;
            MySqlConnection conn = Connection.Conn();

            try
            {
                String cmdStr = "SELECT * FROM CONCURSOS";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                ltsConcursos = new List<Concurso>();
                while (dr.Read())
                {
                    Concurso objConcurso = new Concurso();
                    objConcurso.IdConcurso = int.Parse(dr["idConcurso"].ToString());
                    objConcurso.IdSede = int.Parse(dr["idSede"].ToString());
                    objConcurso.Titulo = dr["titulo"].ToString();
                    objConcurso.Locacion = dr["locacion"].ToString();
                    objConcurso.Nombre = dr["nombre"].ToString();
                    objConcurso.InfoFacturacion = dr["infoFacturacion"].ToString();
                    objConcurso.Email = dr["email"].ToString();

                    ltsConcursos.Add(objConcurso);
                }
            }
            catch (MySqlException ex)
            {
                ltsConcursos = null;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ltsConcursos;
        }
        /// <summary>
        /// Consulta los concursos que tiene una sede a la base de datos
        /// </summary>
        /// <returns>Una lista de concursos</returns>
        public List<Concurso> SELECT_FOR_SEDE(int idSede)
		{
			List<Concurso> ltsConcursos = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "SELECT * FROM CONCURSOS WHERE idSede=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",idSede);
				MySqlDataReader dr = cmd.ExecuteReader();
				ltsConcursos = new List<Concurso>();
				while (dr.Read())
				{
					Concurso objConcurso = new Concurso();
					objConcurso.IdConcurso = int.Parse(dr["idConcurso"].ToString());
					objConcurso.IdSede = int.Parse(dr["idSede"].ToString());
					objConcurso.Titulo = dr["titulo"].ToString();
					objConcurso.Locacion = dr["locacion"].ToString();
					objConcurso.Nombre = dr["nombre"].ToString();
					objConcurso.InfoFacturacion = dr["infoFacturacion"].ToString();
					objConcurso.Email = dr["email"].ToString();

					ltsConcursos.Add(objConcurso);
				}
			}
			catch (MySqlException ex)
			{
				ltsConcursos = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return ltsConcursos;
		}

		/// <summary>
		/// Consulta un concurso de la base de datos por medio de llave primaria
		/// </summary>
		/// <param name="idConsurso">Llave primaria</param>
		/// <returns>Un concurso</returns>
		public Concurso SELECT(int idConsurso)
		{
			Concurso objConcurso = null;
			MySqlConnection conn = Connection.Conn();

			try
			{
				String cmdStr = "SELECT * FROM CONCURSOS where idConcurso=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id", idConsurso);
				MySqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					objConcurso = new Concurso();
					objConcurso.IdConcurso = int.Parse(dr["idConcurso"].ToString());
					objConcurso.IdSede = int.Parse(dr["idSede"].ToString());
					objConcurso.Titulo = dr["titulo"].ToString();
					objConcurso.Locacion = dr["locacion"].ToString();
					objConcurso.Nombre = dr["nombre"].ToString();
					objConcurso.InfoFacturacion = dr["infoFacturacion"].ToString();
					objConcurso.Email = dr["email"].ToString();
				}
			}
			catch (MySqlException ex)
			{
				objConcurso = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return objConcurso;
		}

		/// <summary>
		/// Inserta un concurso en la base de datos
		/// </summary>
		/// <param name="objConcurso">El concurso a insertar</param>
		/// <returns>El Valor de la llave primaria que le pertenece</returns>
		public int INSERT(Concurso objConcurso)
		{
			int done = 0;
			MySqlConnection conn = Connection.Conn();
			try
			{
				String cmdStr = "INSERT INTO CONCURSOS(idSede,nombre,titulo,email,locacion,infoFacturacion) " +
					"VALUES(@idSede,@nombre,@titulo,@email,@locacion,@infoFacturacion)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idSede",objConcurso.IdSede);
				cmd.Parameters.AddWithValue("@nombre",objConcurso.Nombre);
				cmd.Parameters.AddWithValue("@titulo",objConcurso.Titulo);
				cmd.Parameters.AddWithValue("@email",objConcurso.Email);
				cmd.Parameters.AddWithValue("@locacion",objConcurso.Locacion);
				cmd.Parameters.AddWithValue("@infoFacturacion",objConcurso.InfoFacturacion);

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
		/// Actualiza un concurso en la base de datos
		/// </summary>
		/// <param name="objConcurso">El concurso a actualizar</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Concurso objConcurso)
		{
			bool done = false;
			MySqlConnection conn = Connection.Conn();
			try
			{
				String cmdStr = "UPDATE CONCURSOS SET nombre=@nombre,titulo=@titulo,email=@email," +
					"locacion=@locacion,infoFacturacion=@infoFacturacion WHERE idConcurso=@idConcurso";

				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idConcurso",objConcurso.IdConcurso);
				cmd.Parameters.AddWithValue("@nombre", objConcurso.Nombre);
				cmd.Parameters.AddWithValue("@titulo", objConcurso.Titulo);
				cmd.Parameters.AddWithValue("@email", objConcurso.Email);
				cmd.Parameters.AddWithValue("@locacion", objConcurso.Locacion);
				cmd.Parameters.AddWithValue("@infoFacturacion", objConcurso.InfoFacturacion);

				cmd.ExecuteNonQuery();
				done = true;
			}
			catch (MySqlException ex)
			{
				done = false;
				Console.WriteLine(ex.ToString());
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
