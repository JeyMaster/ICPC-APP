using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoInstitucion
	{
		/// <summary>
		/// Inserta una institucion en la base de datos
		/// </summary>
		/// <param name="objInstitucion">Institucion a insertar</param>
		/// <returns>Valor de la llave primaria que le pertenece</returns>
		public int INSERT(Institucion objInstitucion)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "INSERT INTO INSTITUCIONES(idRegion,nombreCompleto,nombreCorto,paginaWeb,gradoOfrecido," +
					"companiaCalle,ciudad,state,lineaDeCalle2,codigoPostal,estado,lineaDeCalle3) " +
					"VALUES(@idRegion,@nombreCompleto,@nombreCorto,@paginaWeb,@gradoOfrecido,@companiaCalle," +
					"@ciudad,@state,@lineaDeCalle2,@codigoPostal,@estado,@lineaDeCalle3)";

				MySqlCommand cmd = new MySqlCommand(cmdStr,conn);
                
                cmd.Parameters.AddWithValue("@nombreCompleto",objInstitucion.NombreCompleto);
				cmd.Parameters.AddWithValue("@nombreCorto",objInstitucion.NombreCorto);
				cmd.Parameters.AddWithValue("@paginaWeb",objInstitucion.PaginaWeb);
				cmd.Parameters.AddWithValue("@gradoOfrecido",objInstitucion.GradoOfrecido);
				cmd.Parameters.AddWithValue("@companiaCalle",objInstitucion.CompaniaCalle);
				cmd.Parameters.AddWithValue("@ciudad",objInstitucion.Ciudad);
				cmd.Parameters.AddWithValue("@state",objInstitucion.State);
				cmd.Parameters.AddWithValue("@lineaDeCalle2",objInstitucion.LineaDeCalle_2);
				cmd.Parameters.AddWithValue("@codigoPostal",objInstitucion.CodigoPostal);
				cmd.Parameters.AddWithValue("@estado",objInstitucion.Estado);
				cmd.Parameters.AddWithValue("@lineaDeCalle3",objInstitucion.LineaDeCalle_3);
                cmd.Parameters.AddWithValue("@idRegion", objInstitucion.IdRegion);
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
        public List<Institucion> SELECT_ALL_JOIN()
        {
            MySqlConnection conn = Connection.Conn();
            List<Institucion> ltsInstituciones = null;
            try
            {
                String cmdStr = "select i.idInstitucion,i.idRegion,r.nombre as Rnombre,i.nombreCompleto,i.nombreCorto,i.paginaWeb,i.gradoOfrecido,i.companiaCalle,i.ciudad,i.State,i.lineaDeCalle2,i.codigoPostal,i.estado,i.lineaDeCalle3 "+
                                "from instituciones i join regiones r "+
                                "where i.idRegion = r.idRegion; ";
                MySqlCommand cmd = new MySqlCommand(cmdStr, conn);

                MySqlDataReader dr = cmd.ExecuteReader();
                ltsInstituciones = new List<Institucion>();
                while (dr.Read())
                {
                    Institucion objInstitucion = new Institucion();

                    objInstitucion.IdInstitucion = int.Parse(dr["idInstitucion"].ToString());
                    objInstitucion.IdRegion = int.Parse(dr["idRegion"].ToString());
                    objInstitucion.NombreRegion = dr["Rnombre"].ToString();
                    objInstitucion.NombreCompleto = dr["nombreCompleto"].ToString();
                    objInstitucion.NombreCorto = dr["nombreCorto"].ToString();
                    objInstitucion.PaginaWeb = dr["paginaWeb"].ToString();
                    objInstitucion.GradoOfrecido = dr["gradoOfrecido"].ToString();
                    objInstitucion.CompaniaCalle = dr["companiaCalle"].ToString();
                    objInstitucion.Ciudad = dr["ciudad"].ToString();
                    objInstitucion.State = dr["State"].ToString();
                    objInstitucion.LineaDeCalle_2 = dr["lineaDeCalle2"].ToString();
                    objInstitucion.CodigoPostal = dr["codigoPostal"].ToString();
                    objInstitucion.Estado = dr["estado"].ToString();
                    objInstitucion.LineaDeCalle_3 = dr["lineaDeCalle3"].ToString();

                    ltsInstituciones.Add(objInstitucion);
                }
            }
            catch (MySqlException ex)
            {
                ltsInstituciones = null;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return ltsInstituciones;
        }
        /// <summary>
        /// Consulta las instituciones en la base de datos
        /// </summary>
        /// <returns>Una lista de instituciones</returns>
        public List<Institucion> SELECT()
		{
			MySqlConnection conn = Connection.Conn();
			List<Institucion> ltsInstituciones = null;
			try
			{
				String cmdStr = "SELECT * FROM INSTITUCIONES";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);

				MySqlDataReader dr = cmd.ExecuteReader();
				ltsInstituciones = new List<Institucion>();
				while (dr.Read())
				{
					Institucion objInstitucion = new Institucion();

					objInstitucion.IdInstitucion = int.Parse(dr["idInstitucion"].ToString());
                    objInstitucion.IdRegion = int.Parse(dr["idRegion"].ToString());
                    objInstitucion.NombreCompleto = dr[1].ToString();
					objInstitucion.NombreCorto = dr[2].ToString();
					objInstitucion.PaginaWeb = dr[3].ToString();
					objInstitucion.GradoOfrecido = dr[4].ToString();
					objInstitucion.CompaniaCalle = dr[5].ToString();
					objInstitucion.Ciudad = dr[6].ToString();
					objInstitucion.State = dr[7].ToString();
					objInstitucion.LineaDeCalle_2 = dr[8].ToString();
					objInstitucion.CodigoPostal = dr[9].ToString();
					objInstitucion.Estado = dr[10].ToString();
					objInstitucion.LineaDeCalle_3 = dr[11].ToString();

					ltsInstituciones.Add(objInstitucion);
				}
			}
			catch (MySqlException ex)
			{
				ltsInstituciones = null;
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ltsInstituciones;
		}

		/// <summary>
		/// Consulata una institucion
		/// </summary>
		/// <param name="idInstitucion">llave primaria de la institucion</param>
		/// <returns>Una institucion</returns>
		public Institucion SELECT(int idInstitucion)
		{
			MySqlConnection conn = Connection.Conn();
			Institucion objInstitucion = null;
			try
			{
				String cmdStr = "SELECT * FROM INSTITUCIONES WHERE idInstitucion=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@id",idInstitucion);

				MySqlDataReader dr = cmd.ExecuteReader();

				objInstitucion = new Institucion();
				while (dr.Read())
				{
			
					objInstitucion.IdInstitucion = int.Parse(dr["idInstitucion"].ToString());
                    objInstitucion.IdRegion = int.Parse(dr["idRegion"].ToString());
                    objInstitucion.NombreCompleto = dr[1].ToString();
					objInstitucion.NombreCorto = dr[2].ToString();
					objInstitucion.PaginaWeb = dr[3].ToString();
					objInstitucion.GradoOfrecido = dr[4].ToString();
					objInstitucion.CompaniaCalle = dr[5].ToString();
					objInstitucion.Ciudad = dr[6].ToString();
					objInstitucion.State = dr[7].ToString();
					objInstitucion.LineaDeCalle_2 = dr[8].ToString();
					objInstitucion.CodigoPostal = dr[9].ToString();
					objInstitucion.Estado = dr[10].ToString();
					objInstitucion.LineaDeCalle_3 = dr[11].ToString();

				}

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				objInstitucion = null;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return objInstitucion;
		}

		/// <summary>
		/// Actualiza una institucion en la base de datos
		/// </summary>
		/// <param name="objInstitucion">Institucion a actualizar</param>
		/// <returns>Booleano</returns>
		public bool UPDATE(Institucion objInstitucion)
		{
			MySqlConnection conn = Connection.Conn();
			bool done = false;
			try
			{
				String cmdStr = "UPDATE INSTITUCIONES SET nombreCompleto=@nombreCompleto,nombreCorto=@nombreCorto," +
					"paginaWeb=@paginaWeb,gradoOfrecido=@gradoOfrecido,companiaCalle=@companiaCalle,ciudad=@ciudad," +
					"state=@state,lineaDeCalle2=@lineaDeCalle2,codigoPostal=@codigoPostal,estado=@estado," +
					"lineaDeCalle3=@lineaDeCalle3,idRegion=@idRegion WHERE idInstitucion=@id";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);

				cmd.Parameters.AddWithValue("@id", objInstitucion.IdInstitucion);
				cmd.Parameters.AddWithValue("@nombreCompleto", objInstitucion.NombreCompleto);
				cmd.Parameters.AddWithValue("@nombreCorto", objInstitucion.NombreCorto);
				cmd.Parameters.AddWithValue("@paginaWeb", objInstitucion.PaginaWeb);
				cmd.Parameters.AddWithValue("@gradoOfrecido", objInstitucion.GradoOfrecido);
				cmd.Parameters.AddWithValue("@companiaCalle", objInstitucion.CompaniaCalle);
				cmd.Parameters.AddWithValue("@ciudad", objInstitucion.Ciudad);
				cmd.Parameters.AddWithValue("@state", objInstitucion.State);
				cmd.Parameters.AddWithValue("@lineaDeCalle2", objInstitucion.LineaDeCalle_2);
				cmd.Parameters.AddWithValue("@codigoPostal", objInstitucion.CodigoPostal);
				cmd.Parameters.AddWithValue("@estado", objInstitucion.Estado);
				cmd.Parameters.AddWithValue("@lineaDeCalle3", objInstitucion.LineaDeCalle_3);
                cmd.Parameters.AddWithValue("@idRegion", objInstitucion.IdRegion);

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
