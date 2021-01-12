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
	public partial class FrmReporteEquipoSede : Form
	{
		public FrmReporteEquipoSede()
		{
			InitializeComponent();
		}

		

		private void FrmReporteEquipoSede_Load(object sender, EventArgs e)
		{
			int limite = DateTime.Now.Year;

			for (int i = 1999; i <= limite; i++)
			{
				cboAnio.Items.Add(i);
			}
			cboAnio.SelectedIndex = 0;
		}

		private void dgvReporte_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnMostrarReporte_Click(object sender, EventArgs e)
		{
			DataSet ds = new Reportes().EQUIPO_SEDE((int)cboAnio.SelectedItem);
			dgvReporte.DataSource = null;
			dgvReporte.DataSource = ds.Tables[0];
		}
	}
}
