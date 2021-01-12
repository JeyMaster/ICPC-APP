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
    public partial class FrmAgregarEditarSedes : Form
    {
        

        public FrmAgregarEditarSedes()
        {
            InitializeComponent();
            editar = false;
            btnGuardarCambios.Text = "Agregar";

        }

        public FrmAgregarEditarSedes(Sede sedeParaEditar)
        {
            InitializeComponent();
            editar = true;
            sedeAEditar = sedeParaEditar;
        }
        bool editar;
        Sede sedeAEditar;
        Sede sedeAAgregar = new Sede();
        DaoSede objDaoSede = new DaoSede();

        private void FrmAgregarEditarSedes_Load(object sender, EventArgs e)
        {
            cargarRegiones();
            if (editar)
            {
                this.Text = "Editar";
                
                txtIdSede.Text = sedeAEditar.IdSede.ToString();
                //txtIdRegion.Text = sedeAEditar.IdRegion.ToString();
                cbIdRegion.Visible = false;
                lblIdRegion.Visible = false;

                txtNombre.Text = sedeAEditar.Nombre;
                
                
                lblIdSede.Visible = false;
                txtIdSede.Visible = false;
                
                
            }
            else
            {
                this.Text = "Agregar";
                txtIdSede.Visible = false;
                lblIdSede.Visible = false;
                cbIdRegion.SelectedIndex = 0;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            
            bool nombre = Validaciones(Strings.Nombres, txtNombre, "Nombre no valido ");
           

            if (nombre)
            {
                if (editar)
                {
                    sedeAEditar.Nombre = txtNombre.Text;

                    bool res = objDaoSede.UPDATE(sedeAEditar);
                    if (res)
                    {
                        MessageBox.Show("Sede Actualizada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Actualizar La Sede", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Modelo.Region newRegion = (Modelo.Region)cbIdRegion.SelectedItem;
                    sedeAAgregar.IdRegion = newRegion.IdRegion;

                    sedeAAgregar.Nombre = txtNombre.Text;


                    int res = objDaoSede.INSERT(sedeAAgregar);
                    if (res != 0)
                    {
                        MessageBox.Show("Sede Agregada Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar La Sede ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errPSedes.SetError(txtComponent, msg);
                done = false;
            }
            else
            {
                errPSedes.SetError(txtComponent, "");
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
