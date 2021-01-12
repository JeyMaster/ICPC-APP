using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAOS;

namespace Vistas
{
    public partial class FrmEquiposMiembro : Form
    {
        public FrmEquiposMiembro()
        {
            InitializeComponent();
        }

		private int year = 1999;
		private int index;


		private void FrmEquiposMiembro_Load(object sender, EventArgs e)
		{
			int limite =DateTime.Now.Year;

			for (int i = year; i <= limite; i++)
			{
				cboAnio.Items.Add(i);
			}
			cboAnio.SelectedIndex = 0;
			llenarTabla();
		}

		private void llenarTabla()
		{
			DataSet ds = new Reportes().EQUIPOS_MIEMBRO(FrmLogin.user.Email, year);
			if (ds!=null)
			{
				dgvEquipos.DataSource = ds.Tables[0];
				dgvEquipos.Columns[4].Visible = false;

			}
		}

		private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
		{
			year = (int)cboAnio.SelectedItem;
			llenarTabla();
		}

		private void btnMostrarIntegrantes_Click(object sender, EventArgs e)
		{


			if (index != 0)
			{
				DataSet ds = new Reportes().EQUIPO_MIEMBROS(index);
				dgvIntegrantes.DataSource = ds.Tables[0];
				dgvIntegrantes.Visible = true;
				lblInte.Visible = true;
			}
			else
			{
				lblInte.Visible = false;
				dgvIntegrantes.Visible = false;
				MessageBox.Show("Selecione un equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvIntegrantes.Visible = false;
			lblInte.Visible = false;

			try
			{
				index = dgvEquipos.CurrentRow.Index;
				index = (int)dgvEquipos[4, index].Value;
			}
			catch (Exception ex)
			{
				
				index = 0;
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
