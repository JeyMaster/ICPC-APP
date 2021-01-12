using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoSede
	{

		/// <summary>
		/// Inserta una sede en la base de datos
		/// </summary>
		/// <param name="objSede">Sede a insertar</param>
		/// <returns>Valor de su llave primaria</returns>
		public int INSERT(Sede objSede)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "INSERT INTO SEDES(nombre,idRegion) VALUES(@nombre,@idRegion)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@nombre",objSede.Nombre);
				cmd.Parameters.AddWithValue("@idRegion",objSede.IdRegion);

				cmd.ExecuteNonQuery();
				done = (int)cmd.LastInsertedId;
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = 0;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return done;
		}
        public List<Sede> SELECT_ALL_JOIN()
        {
            List<Sede> ltsSede = null;
            MySqlConnection conn = Connection.Conn();

            try
            {
                String cmdStr = "select s.idSede,s.nombre as Snombre,s.idRegion,r.Nombre as Rnombre "+
                                "from Sedes s join regiones r "+
                                "where s.idRegion = r.idRegion ";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                ltsSede = new List<Sede>();
                while (dr.Read())
                {
                    Sede objSede = new Sede();
                    objSede.IdSede = int.Parse(dr["idSede"].ToString());
                    objSede.IdRegion = int.Parse(dr["idRegion"].ToString());
                    objSede.Nombre = dr["Snombre"].ToString();
                    objSede.NombreRegion = dr["Rnombre"].ToString();


                    ltsSede.Add(objSede);
                }
            }
            catch (MySqlException ex)
            {
                ltsSede = null;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ltsSede;
        }
        /// <summary>
        /// Regresa un select de todas las sedes de la base de datos
        /// </summary>
        /// <returns>lista de sedes</returns>
        public List<Sede> SELECT_ALL()
        {
            List<Sede> ltsSede = null;
            MySqlConnection conn = Connection.Conn();

            try
            {
                String cmdStr = "SELECT * FROM SEDES";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                ltsSede = new List<Sede>();
                while (dr.Read())
                {
                    Sede objSede = new Sede();
                    objSede.IdSede = int.Parse(dr["idSede"].ToString());
                    objSede.IdRegion = int.Parse(dr["idRegion"].ToString());
                    objSede.Nombre = dr["nombre"].ToString();
                    

                    ltsSede.Add(objSede);
                }
            }
            catch (MySqlException ex)
            {
                ltsSede = null;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ltsSede;
        }

        /// <summary>
        /// Consulta las sedes que tiene una region en la base de datos
        /// </summary>
        /// <returns>Una lista de Sedes</returns>
        public List<Sede> SELECT_FOR_REGION(int idRegion)
		{
			MySqlConnection conn = Connection.Conn();
			List<Sede> ltsSedes = null;
			try
			{
				String cmdStr = "SELECT * FROM SEDES WHERE idRegion=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",idRegion);
				MySqlDataReader dr = cmd.ExecuteReader();
				ltsSedes = new List<Sede>();

				while (dr.Read())
				{
					Sede objSede = new Sede();

					objSede.IdSede = int.Parse(dr[0].ToString());
					objSede.Nombre = dr[1].ToString();
					objSede.IdRegion = int.Parse(dr[2].ToString());

					ltsSedes.Add(objSede);
				}

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				ltsSedes = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ltsSedes;
		}

		/// <summary>
		/// Consulta una sede en la base de datos 
		/// </summary>
		/// <param name="idSede"></param>
		/// <returns>Una sede</returns>
		public Sede SELECT(int idSede)
		{
			MySqlConnection conn = Connection.Conn();
			Sede objSede = null;
			try
			{
				String cmdStr = "SELECT * FROM SEDES WHERE idSede=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",idSede);

				MySqlDataReader dr = cmd.ExecuteReader();
				objSede = new Sede();

				while (dr.Read())
				{

					objSede.IdSede = int.Parse(dr[0].ToString());
					objSede.Nombre = dr[1].ToString();
					objSede.IdRegion = int.Parse(dr[2].ToString());

				}
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				objSede = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return objSede;
		}

		/// <summary>
		/// Actualiza una sede en la base de datos
		/// </summary>
		/// <param name="objSede">La sede a actualizar</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Sede objSede)
		{
			MySqlConnection conn = Connection.Conn();
			bool done = false;
			try
			{
				String cmdStr = "UPDATE SEDES SET nombre=@nombre,idRegion=@idRegion WHERE idSede=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",objSede.IdSede);
				cmd.Parameters.AddWithValue("@nombre", objSede.Nombre);
				cmd.Parameters.AddWithValue("@idRegion", objSede.IdRegion);

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
