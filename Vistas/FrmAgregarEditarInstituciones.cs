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
    public partial class FrmAgregarEditarInstituciones : Form
    {

        public FrmAgregarEditarInstituciones()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";
        }

        public FrmAgregarEditarInstituciones(Institucion InstitucionParaEditar)
        {
            InitializeComponent();
            editar = true;
            institucionAEditar = InstitucionParaEditar;
        }

        bool editar;
        Institucion institucionAEditar=new Institucion();
        Institucion InstitucionAAgregar = new Institucion();
        DaoInstitucion objDaoInstitucion = new DaoInstitucion();
        private void FrmAgregarEditarInstituciones_Load(object sender, EventArgs e)
        {
            cargarRegiones();
            if (editar)
            {
                this.Text = "Editar";
                

                txtNombreCompleto.Text =institucionAEditar.NombreCompleto;
                txtNombreCorto.Text = institucionAEditar.NombreCorto;
                txtPaginaWeb.Text = institucionAEditar.PaginaWeb;
                txtGradoOfrecido.Text = institucionAEditar.GradoOfrecido;
                txtCompañiaCalle.Text= institucionAEditar.CompaniaCalle;
                txtState.Text = institucionAEditar.State;
                txtCiudad.Text = institucionAEditar.Ciudad;
                txtCodigoPostal.Text = institucionAEditar.CodigoPostal;
                txtLineaDeCalle2.Text = institucionAEditar.LineaDeCalle_2;
                txtLineaDeCalle3.Text = institucionAEditar.LineaDeCalle_3;
                txtEstado.Text = institucionAEditar.Estado;

                txtIdInstitucion.Visible = false;
                cbIdRegion.Visible = false;
                lblIdInstitucion.Visible = false;
                lblIdRegion.Visible = false;
            }
            else
            {
                this.Text = "Agregar";
                txtIdInstitucion.Visible = false;
                lblIdInstitucion.Visible = false;
                cbIdRegion.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtGuardarCambios_Click(object sender, EventArgs e)
        {
            bool nombreCompleto = Validaciones(Strings.Nombres, txtNombreCompleto, "Titulo no valido ");
            bool nombreCorto = Validaciones(Strings.Nombres, txtNombreCorto, "Nombre no valido ");
            bool paginaWeb = Validaciones(Strings.validarCorreo, txtPaginaWeb, "Email no valido ");
            bool gradoOfrecido = Validaciones(Strings.Nombres, txtGradoOfrecido, "Locacion no valida ");
            bool companiaCalle = Validaciones(Strings.Nombres, txtCompañiaCalle, "Informacion De Facturacion no valida ");
            bool state = Validaciones(Strings.Nombres, txtState, "Titulo no valido ");
            bool ciudad = Validaciones(Strings.Nombres, txtCiudad, "Nombre no valido ");
            bool codigoPostal = Validaciones(Strings.validarCorreo, txtCodigoPostal, "Email no valido ");
            bool lineaDeCalle2 = Validaciones(Strings.Nombres, txtLineaDeCalle2, "Locacion no valida ");
            bool lineaDeCalle3 = Validaciones(Strings.Nombres, txtLineaDeCalle3, "Informacion De Facturacion no valida ");
            bool estado = Validaciones(Strings.Nombres, txtEstado, "Titulo no valido ");
            

            if (nombreCompleto & nombreCorto & paginaWeb & gradoOfrecido & companiaCalle & state & ciudad & codigoPostal & lineaDeCalle2 & lineaDeCalle3 & estado)
            {
                if (editar)
                {


                    institucionAEditar.NombreCompleto = txtNombreCompleto.Text;
                    institucionAEditar.NombreCorto = txtNombreCorto.Text;
                    institucionAEditar.PaginaWeb = txtPaginaWeb.Text;
                    institucionAEditar.GradoOfrecido = txtGradoOfrecido.Text;
                    institucionAEditar.CompaniaCalle = txtCompañiaCalle.Text;
                    institucionAEditar.State = txtState.Text;
                    institucionAEditar.Ciudad = txtCiudad.Text;
                    institucionAEditar.CodigoPostal = txtCodigoPostal.Text;
                    institucionAEditar.LineaDeCalle_2 = txtLineaDeCalle2.Text;
                    institucionAEditar.LineaDeCalle_3 = txtLineaDeCalle3.Text;
                    institucionAEditar.Estado = txtEstado.Text;

                    bool res = objDaoInstitucion.UPDATE(institucionAEditar);
                    if (res)
                    {
                        MessageBox.Show("Institucion Actualizada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Actualizar La Institucion", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Modelo.Region newRegion = (Modelo.Region)cbIdRegion.SelectedItem;
                    InstitucionAAgregar.IdRegion = newRegion.IdRegion;

                    InstitucionAAgregar.NombreCompleto = txtNombreCompleto.Text;
                    InstitucionAAgregar.NombreCorto = txtNombreCorto.Text;
                    InstitucionAAgregar.PaginaWeb = txtPaginaWeb.Text;
                    InstitucionAAgregar.GradoOfrecido = txtGradoOfrecido.Text;
                    InstitucionAAgregar.CompaniaCalle = txtCompañiaCalle.Text;
                    InstitucionAAgregar.State = txtState.Text;
                    InstitucionAAgregar.Ciudad = txtCiudad.Text;
                    InstitucionAAgregar.CodigoPostal = txtCodigoPostal.Text;
                    InstitucionAAgregar.LineaDeCalle_2 = txtLineaDeCalle2.Text;
                    InstitucionAAgregar.LineaDeCalle_3 = txtLineaDeCalle3.Text;
                    InstitucionAAgregar.Estado = txtEstado.Text;

                    int res = objDaoInstitucion.INSERT(InstitucionAAgregar);
                    if (res != 0)
                    {
                        MessageBox.Show("Institucion Agregada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar La Institucion ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        Regex automata;
        private bool Validaciones(String validacion, TextBox txtComponent, String msg)
        {
            bool done = false;
            automata = new Regex(validacion);
            if (!automata.IsMatch(txtComponent.Text))
            {
                errPInstituciones.SetError(txtComponent, msg);
                done = false;
            }
            else
            {
                errPInstituciones.SetError(txtComponent, "");
                done = true;
            }

            return done;
        }
        private void cargarRegiones()
        {
            List<Modelo.Region> ltsRegiones = new DaoRegion().SELECT();

            foreach (Modelo.Region region in ltsRegiones)
            {
                cbIdRegion.Items.Add(region);
            }
        }
    }
}
