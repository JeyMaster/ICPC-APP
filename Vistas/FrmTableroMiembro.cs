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
    public partial class FrmTableroMiembro : Form
    {
        public FrmTableroMiembro()
        {
            InitializeComponent();
			lblNombre.Text = "\""+FrmLogin.user.Nombre+"\"";
        }

        private void abrirFromHijo(object formhijo) {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
        Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmPerfilMiembro());
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmCrearEquipo());
        }

        private void btnAdminEquipos_Click(object sender, EventArgs e)
        {
            abrirFromHijo(new FrmEquiposMiembro());
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
