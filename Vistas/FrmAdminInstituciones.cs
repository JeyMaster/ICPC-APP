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
    public partial class FrmAdminInstituciones : Form
    {
        public FrmAdminInstituciones()
        {
            InitializeComponent();
        }
        DaoInstitucion objDaoInstitucion = new DaoInstitucion();
        private void FrmAdminInstituciones_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        bool editIsPossible = false;
        public void CargarTabla()
        {
            List<Institucion> ltsConcursos = objDaoInstitucion.SELECT_ALL_JOIN();
            dgvInstituciones.DataSource = ltsConcursos;
            dgvInstituciones.Columns[0].Visible = false;
            dgvInstituciones.Columns[1].Visible = false;
        }
        String rowclicked;
        String idInstitucionXfila;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregarEditarInstituciones().ShowDialog();
            CargarTabla();
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editIsPossible)
            {
                Institucion InstitucionAEditar = objDaoInstitucion.SELECT(Int32.Parse(idInstitucionXfila));
                new FrmAgregarEditarInstituciones(InstitucionAEditar).ShowDialog();
                CargarTabla();
                editIsPossible = false;
            }
            else
            {
                MessageBox.Show("Selecciona Un Elemento de la tabla a Editar ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvInstituciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editIsPossible = true;
            rowclicked = dgvInstituciones.CurrentCell.RowIndex.ToString();
            idInstitucionXfila = dgvInstituciones.Rows[Int32.Parse(rowclicked)].Cells[0].Value.ToString();
        }
    }
}
