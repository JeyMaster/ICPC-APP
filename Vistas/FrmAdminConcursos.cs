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
    public partial class FrmAdminConcursos : Form
    {
        public FrmAdminConcursos()
        {
            InitializeComponent();
        }
        DaoConcurso objDaoConcuro = new DaoConcurso();
        private void FrmAdminConcursos_Load(object sender, EventArgs e)
        {
            CargarTabla();
            

        }
        String rowclicked;
        String idConcursoXfila;
        bool editIsPossible=false;
        private void dgvConcursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editIsPossible = true;
           
                rowclicked = dgvConcursos.CurrentCell.RowIndex.ToString();
                idConcursoXfila = dgvConcursos.Rows[Int32.Parse(rowclicked)].Cells[0].Value.ToString();
            
             
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (editIsPossible)
            {
                Concurso concursoAEditar = objDaoConcuro.SELECT(Int32.Parse(idConcursoXfila));
                new FrmAgregarEditarConcursos(concursoAEditar).ShowDialog();
                CargarTabla();
                editIsPossible = false;
            }
            else {
                MessageBox.Show("Selecciona Un Elemento de la tabla a Editar ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        public void CargarTabla() {
            List<Concurso> ltsConcursos = objDaoConcuro.SELECT_ALL_JOIN();
            dgvConcursos.DataSource = ltsConcursos;
            dgvConcursos.Columns[0].Visible = false;
            dgvConcursos.Columns[1].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            new FrmAgregarEditarConcursos().ShowDialog();
            CargarTabla();
        }
    }
}
