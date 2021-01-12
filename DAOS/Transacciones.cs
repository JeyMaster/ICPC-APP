using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace DAOS
{
	public class Transacciones
	{
		public bool INSERT_FULL_EQUIPO(Equipo equipo,List<DetalleEquipo> detalleEquipos,DetalleConcurso detalleConcurso)
		{
			bool ok = false;
			int done = 0;
			MySqlConnection conn = Connection.Conn();
			MySqlTransaction tr = null;
			try
			{
				tr = conn.BeginTransaction();
				String cmdStr = "INSERT INTO EQUIPOS(nombre,idInstitucion,ciclo) " +
					"VALUES(@nombre,@idInstitucion,@ciclo)";
				MySqlCommand cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@nombre", equipo.Nombre);
				cmd.Parameters.AddWithValue("@idInstitucion", equipo.IdInstitucion);
				cmd.Parameters.AddWithValue("@ciclo", equipo.Ciclo);

				cmd.ExecuteNonQuery();
				done = (int)cmd.LastInsertedId;

				foreach (DetalleEquipo detalleEquipo in detalleEquipos)
				{
					cmdStr = "INSERT INTO DETALLE_EQUIPO VALUES(@idEquipo,@email,@rol)";
					cmd = new MySqlCommand(cmdStr, conn);
					cmd.Parameters.AddWithValue("@email", detalleEquipo.Email);
					cmd.Parameters.AddWithValue("@idEquipo", done);
					cmd.Parameters.AddWithValue("@rol", detalleEquipo.Rol);

					cmd.ExecuteNonQuery();
				}

				cmdStr = "INSERT INTO DETALLE_CONCURSO VALUES(@idConcurso,@idEquipo)";
				cmd = new MySqlCommand(cmdStr, conn);
				cmd.Parameters.AddWithValue("@idConcurso", detalleConcurso.IdConcurso);
				cmd.Parameters.AddWithValue("@idEquipo", done);

				cmd.ExecuteNonQuery();
				ok = true;
				tr.Commit();
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				tr.Rollback();
				ok = false;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return ok;
		}
	}
}
