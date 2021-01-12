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
    public partial class FrmAdminSedes : Form
    {
        public FrmAdminSedes()
        {
            InitializeComponent();
        }
        DaoSede objDaoSede = new DaoSede();
        private void FrmAdminSedes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new FrmAgregarEditarSedes().ShowDialog();
            CargarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (editIsPossible)
            {
                Sede sedeAEditar = objDaoSede.SELECT(Int32.Parse(idSedeXfila));
                new FrmAgregarEditarSedes(sedeAEditar).ShowDialog();
                CargarTabla();
                editIsPossible = false;
            }
            else
            {
                MessageBox.Show("Selecciona Un Elemento de la tabla a Editar ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        String rowclicked;
        String idSedeXfila;
        bool editIsPossible = false;
        private void dgvSedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowclicked = dgvSedes.CurrentCell.RowIndex.ToString();
            idSedeXfila = dgvSedes.Rows[Int32.Parse(rowclicked)].Cells[0].Value.ToString();
            editIsPossible = true;
        }
        public void CargarTabla()
        {
            List<Sede> ltsSedes = objDaoSede.SELECT_ALL_JOIN();
            dgvSedes.DataSource = ltsSedes;
            dgvSedes.Columns[0].Visible = false;
            dgvSedes.Columns[2].Visible = false;
        }
    }
}
