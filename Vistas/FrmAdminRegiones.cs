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
using Modelo;

namespace Vistas
{
    public partial class FrmAdminRegiones : Form
    {
        DaoRegion objDaoRegiones = new DaoRegion();
        public FrmAdminRegiones()
        {
            InitializeComponent();
			cargarTabla();

        }
		private int index;
		private void cargarTabla()
		{
			List<Modelo.Region> ltsregiones = new DaoRegion().SELECT();

			dgvRegiones.DataSource = null;
			dgvRegiones.DataSource = ltsregiones;
            dgvRegiones.Columns[0].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

			new FrmAgregarEditarRegiones(null).ShowDialog();
			cargarTabla();
        }

		private void btnEditar_Click(object sender, EventArgs e)
		{
			Modelo.Region region = new Modelo.Region();
			region.IdRegion = (int)dgvRegiones[0, index].Value;
			region.Nombre = dgvRegiones[1, index].Value.ToString();
			new FrmAgregarEditarRegiones(region).ShowDialog();
			cargarTabla();
		}

		private void dgvRegiones_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			index = dgvRegiones.CurrentRow.Index;
		}

        private void FrmAdminRegiones_Load(object sender, EventArgs e)
        {

        }
    }
}
