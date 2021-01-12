using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmTableroAdministrador : Form
    {
        public FrmTableroAdministrador()
        {
            InitializeComponent();
        }
        private void abrirFromHijo(object formhijo)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();
        }
        private void btnAdminRegiones_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmAdminRegiones());
        }

        private void btnAdminSedes_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmAdminSedes());
        }

        private void btnAdminConcursos_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmAdminConcursos());
        }

        private void btnAdminInstituciones_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmAdminInstituciones());
        }

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReporteIntegrante_Click(object sender, EventArgs e)
		{
			new FrmReporteEquipoSede().ShowDialog();
		}

		private void btnReporteRegion_Click(object sender, EventArgs e)
		{
			new FrmReporteRegion().ShowDialog();
		}

		private void btnReporteInstitucion_Click(object sender, EventArgs e)
		{
			new FrmReporteUniversidad().ShowDialog();
		}
	}
}
