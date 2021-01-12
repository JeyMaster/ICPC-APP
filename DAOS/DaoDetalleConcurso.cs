using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class DaoDetalleConcurso
	{
		public int INSERT(DetalleConcurso objDetalleConcurso)
		{
			MySqlConnection conn = Connection.Conn();
			int done = 0;
			try
			{
				String cmdStr = "INSERT INTO DETALLE_CONCURSO VALUES(@idConcurso,@idEquipo)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idConcurso",objDetalleConcurso.IdConcurso);
				cmd.Parameters.AddWithValue("@idEquipo", objDetalleConcurso.IdEquipo);

				cmd.ExecuteNonQuery();

				done = (int)cmd.LastInsertedId;

			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				done = 0;
			}

			return done;
		}
	}
}
