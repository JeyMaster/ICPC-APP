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
using System.Text.RegularExpressions;

namespace Vistas
{
    public partial class FrmAgregarEditarConcursos : Form
    {
        public FrmAgregarEditarConcursos(Modelo.Concurso concursoParaEditar)
        {
            InitializeComponent();
            editar = true;
            ConcuroAEditar = concursoParaEditar;
            
        }
        public FrmAgregarEditarConcursos()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";
            
        }
        bool editar;
        Concurso ConcuroAEditar;
        Concurso ConcuroAAgregar=new Concurso();
        DaoConcurso objDaoConcurso=new DaoConcurso();


        private void FrmAgregarEditarConcursos_Load(object sender, EventArgs e)
        {
            cargarSedes();
            if (editar)
            {
                this.Text = "Editar";
                txtTitulo.Text = ConcuroAEditar.Titulo;
                txtNombre.Text = ConcuroAEditar.Nombre;
                txtEmail.Text = ConcuroAEditar.Email;
                txtLocacion.Text = ConcuroAEditar.Locacion;
                txtInfoFacturacion.Text = ConcuroAEditar.InfoFacturacion;
                txtIdConcurso.Visible = false;
                cbIdSede.Visible = false;
                lblIdConcurso.Visible = false;
                lblIdSede.Visible = false;
                
            }
            else {
                this.Text = "Agregar";
                txtIdConcurso.Visible = false;
                lblIdConcurso.Visible = false;
                cbIdSede.SelectedIndex = 0;
            }
            

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool titulo = Validaciones(Strings.Nombres, txtTitulo, "Titulo no valido ");
            bool nombre = Validaciones(Strings.Nombres, txtNombre, "Nombre no valido ");
            bool email = Validaciones(Strings.validarCorreo, txtEmail, "Email no valido ");
            bool locacion = Validaciones(Strings.Nombres, txtLocacion, "Locacion no valida ");
            bool infofacturacion = Validaciones(Strings.Nombres, txtInfoFacturacion, "Informacion De Facturacion no valida ");

            if (titulo & nombre & email & locacion & infofacturacion) {
                if (editar)
                {
                    
                    ConcuroAEditar.Titulo = txtTitulo.Text;
                    ConcuroAEditar.Nombre = txtNombre.Text;
                    ConcuroAEditar.Email = txtEmail.Text;
                    ConcuroAEditar.Locacion = txtLocacion.Text;
                    ConcuroAEditar.InfoFacturacion = txtInfoFacturacion.Text;
                   

                    bool res = objDaoConcurso.UPDATE(ConcuroAEditar);
                    if (res)
                    {
                        MessageBox.Show("Concurso Actualizado Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Actualizar El Concurso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Sede newSede = (Sede)cbIdSede.SelectedItem;
                    ConcuroAAgregar.IdSede = newSede.IdSede;
                    ConcuroAAgregar.Titulo = txtTitulo.Text;
                    ConcuroAAgregar.Nombre = txtNombre.Text;
                    ConcuroAAgregar.Email = txtEmail.Text;
                    ConcuroAAgregar.Locacion = txtLocacion.Text;
                    ConcuroAAgregar.InfoFacturacion = txtInfoFacturacion.Text;

                    int res = objDaoConcurso.INSERT(ConcuroAAgregar);
                    if (res != 0)
                    {
                        MessageBox.Show("Concurso Agregado Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar El Concurso ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Regex automata;
        private bool Validaciones(String validacion, TextBox txtComponent, String msg)
        {
            bool done = false;
            automata = new Regex(validacion);
            if (!automata.IsMatch(txtComponent.Text))
            {
                errPConcurso.SetError(txtComponent, msg);
                done = false;
            }
            else
            {
                errPConcurso.SetError(txtComponent, "");
                done = true;
            }

            return done;
        }
        private void cargarSedes()
        {
            List<Sede> ltsSedes = new DaoSede().SELECT_ALL();

            foreach (Modelo.Sede sede in ltsSedes)
            {
                cbIdSede.Items.Add(sede);
            }
        }
    }
}
