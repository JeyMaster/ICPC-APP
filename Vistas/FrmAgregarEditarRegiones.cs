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
    public partial class FrmAgregarEditarRegiones : Form
    {
        public FrmAgregarEditarRegiones(Modelo.Region region)
        {
            InitializeComponent();
			this.region = region;
            if (region != null) { editar = true; }
            RegionAEditar = region;
        }
        public FrmAgregarEditarRegiones() 
        {
            InitializeComponent();
            editar = false;
            btnAceptar.Text = "Agregar";
        }
        bool editar;
        Modelo.Region RegionAEditar;
        Modelo.Region RegionAAgregar = new Modelo.Region();
        DaoRegion objDaoConcurso = new DaoRegion();

        private Modelo.Region region;

		private void btnAceptar_Click(object sender, EventArgs e)
		{
            bool nombre = Validaciones(Strings.Nombres, txtNombre, "Nombre no valido ");
           if (nombre) { 
            if (region==null)
			{
				Modelo.Region reg = new Modelo.Region();
				reg.Nombre = txtNombre.Text;
				new DaoRegion().INSERT(reg);
				this.Close();
			}
			else
			{
				Modelo.Region reg = new Modelo.Region();
				reg.Nombre = txtNombre.Text;
				reg.IdRegion = region.IdRegion;
				new DaoRegion().UPDATE(reg);
				this.Close();
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
                errPRegiones.SetError(txtComponent, msg);
                done = false;
            }
            else
            {
                errPRegiones.SetError(txtComponent, "");
                done = true;
            }

            return done;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarEditarRegiones_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                this.Text = "Editar";
                txtNombre.Text = RegionAEditar.Nombre;
                

            }
            else
            {
                this.Text = "Agregar";
            
            }
        }
    }
}
