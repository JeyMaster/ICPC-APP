using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAOS;

namespace Vistas
{
    public partial class FrmCrearEquipo : Form
    {
        public FrmCrearEquipo()
        {
            InitializeComponent();
        }
		
		private List<Modelo.Region> ltsRegiones;
		private List<Sede> ltsSedes;
		private List<Concurso> ltsConcursos;
		private List<DetalleEquipo> ltsDetalleEquipo;
		private int index;

		private void FrmCrearEquipo_Load(object sender, EventArgs e)
		{
			cargarRegiones();
			cargarInstituciones();
			ltsDetalleEquipo = new List<DetalleEquipo>();
			cbRol.SelectedIndex = 0;
		}

		private void cargarInstituciones()
		{
			List<Institucion> ltsInstituciones = new DaoInstitucion().SELECT();

			foreach (Institucion institucion in ltsInstituciones)
			{
				cbInstituciones.Items.Add(institucion);
			}
		}

		private void cargarRegiones()
		{
			ltsRegiones = new DaoRegion().SELECT();

			foreach (Modelo.Region region in ltsRegiones)
			{
				cbRegiones.Items.Add(region);
			}
		}

		private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Sede objSede = (Sede)cbSedes.SelectedItem;
			ltsConcursos = new DaoConcurso().SELECT_FOR_SEDE(objSede.IdSede);
			cbConcursos.Items.Clear();

			if (ltsConcursos!=null)
			{
				foreach (Concurso concurso in ltsConcursos)
				{
					cbConcursos.Items.Add(concurso);
				}

			}
			
		}

		private void cbRegiones_SelectedIndexChanged(object sender, EventArgs e)
		{

			Modelo.Region objRegion = (Modelo.Region)cbRegiones.SelectedItem;
			ltsSedes = new DaoSede().SELECT_FOR_REGION(objRegion.IdRegion);
			cbSedes.Items.Clear();
			cbConcursos.Items.Clear();
			if (ltsSedes != null)
			{
				foreach (Sede sede in ltsSedes)
				{
					cbSedes.Items.Add(sede);
				}
			}
		}

		
		private void btnAgregarIntegrante_Click(object sender, EventArgs e)
		{
			DetalleEquipo objDetalleEquipo = new DetalleEquipo();
			bool existe = false;
	
			
			for (int i = 0; i < ltsDetalleEquipo.Count; i++)
			{
					if (ltsDetalleEquipo.ElementAt(i).Email == cbIntegrante.SelectedItem.ToString()) existe = true;

			}
			


			if (!existe)
			{
				
					objDetalleEquipo.Rol = cbRol.SelectedItem.ToString();
					objDetalleEquipo.Email = cbIntegrante.SelectedItem.ToString();
					ltsDetalleEquipo.Add(objDetalleEquipo);
					dgvIntegrantes.DataSource = null;
					dgvIntegrantes.DataSource = ltsDetalleEquipo;
					dgvIntegrantes.Columns.Remove("idEquipo");
			}
			else
			{
				MessageBox.Show("Miembro ya registrado");
			}



		}


		private void cbIntegrante_KeyUp(object sender, KeyEventArgs e)
		{
			List<Miembro> lts = new DaoMiembro().SELECT_FOR_SEARCH(cbIntegrante.Text);
			cbIntegrante.Items.Clear();

			cbIntegrante.Select(cbIntegrante.Text.Length, 0);

			foreach (Miembro miembro in lts)
			{
				cbIntegrante.Items.Add(miembro);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			
			ltsDetalleEquipo.ElementAt(index).Email = cbIntegrante.Text.ToString();
			ltsDetalleEquipo.ElementAt(index).Rol = cbRol.SelectedItem.ToString();
			dgvIntegrantes.DataSource = null;
			dgvIntegrantes.DataSource = ltsDetalleEquipo;
			dgvIntegrantes.Columns.Remove("idEquipo");
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ltsDetalleEquipo.RemoveAt(index);
			dgvIntegrantes.DataSource = null;
			dgvIntegrantes.DataSource = ltsDetalleEquipo;
			dgvIntegrantes.Columns.Remove("idEquipo");
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (ltsDetalleEquipo.Count<4)
			{
				MessageBox.Show("El equipo minimo requiere un Couch\n" +
					"y 3 participantes");
				return;
			}

			if (ltsDetalleEquipo.Count>10)
			{
				MessageBox.Show("El equipo es muy grande\nCapacidad maxima" +
					"\n1 Couch\n5 Co-Couch\n3 Participantes\n1 Reserva");
				return;
			}

			int couch = 0;
			int cocouch = 0;
			int reserva = 0;
			int participantes = 0;

			for (int i = 0; i < ltsDetalleEquipo.Count; i++)
			{
				if (ltsDetalleEquipo.ElementAt(i).Rol=="Couch")
				{
					couch++;
				}
				if (ltsDetalleEquipo.ElementAt(i).Rol == "Co-Couch")
				{
					cocouch++;
				}
				if (ltsDetalleEquipo.ElementAt(i).Rol == "Participante")
				{
					participantes++;
				}
				if (ltsDetalleEquipo.ElementAt(i).Rol == "Reserva")
				{
					reserva++;
				}
			}

			if (couch==1)
			{
				if (participantes == 3)
				{
					if (cocouch <= 5)
					{
						if (reserva<=1)
						{
							if (cbConcursos.Text != "" && cbInstituciones.Text != "" && cbSedes.Text != ""
								&& cbRegiones.Text != "")
							{
								if (txtNombreEquipo.Text != "")
								{
									Equipo objEquipo = new Equipo();
									objEquipo.Ciclo = dateTimePicker1.Value;
									objEquipo.Nombre = txtNombreEquipo.Text;
									Institucion institucion = (Institucion)cbInstituciones.SelectedItem;
									objEquipo.IdInstitucion = institucion.IdInstitucion;
									Concurso concurso = (Concurso)cbConcursos.SelectedItem;
									DetalleConcurso detalleConcurso = new DetalleConcurso();
									detalleConcurso.IdConcurso = concurso.IdConcurso;

									if (new Transacciones().INSERT_FULL_EQUIPO(objEquipo, ltsDetalleEquipo, detalleConcurso))
									{
										MessageBox.Show("Equipo registrado con exito");
									}

								}
								else
								{
									MessageBox.Show("Ingrese un nombre al equipo");
								}
							}
							else
							{
								MessageBox.Show("Seleccione todos los apartados");
							}
						}
						else
						{
							MessageBox.Show("Solo un reverva");

						}
					}
					else
					{
						MessageBox.Show("No mas de 5 Co-Couch");

					}
				}
				else
				{
					MessageBox.Show("Deben de ser 3 participantes");

				}
			}
			else
			{
				MessageBox.Show("Solo se puede tener un couch");
			}
		}

		private void dgvIntegrantes_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			index = dgvIntegrantes.CurrentRow.Index;
			cbIntegrante.Text = dgvIntegrantes[0, index].Value.ToString();
		}
	}
}
