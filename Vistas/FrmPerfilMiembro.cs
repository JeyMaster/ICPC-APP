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
    public partial class FrmPerfilMiembro : Form
    {
        public FrmPerfilMiembro()
        {
            InitializeComponent();
			txtEmail.Enabled = false;
			cbSexo.SelectedIndex = 0;
			cbTallaDeCamisa.SelectedIndex = 0;
        }

		private void FrmPerfilMiembro_Load(object sender, EventArgs e)
		{
			limpiarCampos();
			TraerDatos();
		}

		private void TraerDatos()
		{
			Miembro objMiembro = new DaoMiembro().SELECT(FrmLogin.user.Email);
			txtEmail.Text = objMiembro.Email;
			txtTitulo.Text = objMiembro.Titulo;
			txtNombre.Text = objMiembro.Nombre;
			txtApellido.Text = objMiembro.Apellido;
			txtApodo.Text = objMiembro.NombreDistintivo;
			txtNombreDeCertificado.Text = objMiembro.NombreDeCertificado;
			dtpFechaDeNacimiento.Value = objMiembro.FechaDeNacimiento;
			txtCiudadDeOrigen.Text = objMiembro.CiudadDeOrigen;
			txtEstadoDeOrigen.Text = objMiembro.EstadoDeOrigen;
			txtPaisOrigen.Text = objMiembro.PaisDeOrigen;
			txtPaisResidencia.Text = objMiembro.PaisDeResidencia;
			txtOcupacion.Text = objMiembro.Ocupacion;
			txtInstitucionEmpleoCompania.Text = objMiembro.InstitutoEmpleoCompania;
			txtNecesidadesEspeciales.Text = objMiembro.NecesidadesEspeciales;
			txtEmailSecundario.Text = objMiembro.EmailSecundario;
			
		}

		private void limpiarCampos()
		{
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtApodo.Text = "";
			txtCiudadDeOrigen.Text="";
			txtEmail.Text = "";
			txtEmailSecundario.Text = "";
			txtEstadoDeOrigen.Text = "";
			txtInstitucionEmpleoCompania.Text = "";
			txtNecesidadesEspeciales.Text = "";
			txtNombreDeCertificado.Text = "";
			txtOcupacion.Text = "";
			txtPaisOrigen.Text = "";
			txtPaisResidencia.Text = "";
			txtTitulo.Text = "";
		
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{

			Miembro objMiembro = new Miembro();
			objMiembro.Titulo= txtTitulo.Text;
			objMiembro.Nombre=txtNombre.Text;
			objMiembro.Apellido= txtApellido.Text;
			objMiembro.NombreDistintivo= txtApodo.Text;
			objMiembro.NombreDeCertificado= txtNombreDeCertificado.Text;
			objMiembro.FechaDeNacimiento= dtpFechaDeNacimiento.Value;
			objMiembro.CiudadDeOrigen= txtCiudadDeOrigen.Text;
			objMiembro.EstadoDeOrigen= txtEstadoDeOrigen.Text;
			objMiembro.PaisDeOrigen= txtPaisOrigen.Text;
			objMiembro.PaisDeResidencia= txtPaisResidencia.Text;
			objMiembro.Ocupacion= txtOcupacion.Text;
			objMiembro.InstitutoEmpleoCompania= txtInstitucionEmpleoCompania.Text;
			objMiembro.NecesidadesEspeciales= txtNecesidadesEspeciales.Text;
			objMiembro.EmailSecundario= txtEmailSecundario.Text;
			objMiembro.PaisDeOrigen = txtPaisOrigen.Text;
			objMiembro.PaisDeResidencia = txtPaisResidencia.Text;
			objMiembro.Email = txtEmail.Text;
			char sexo='M';
			if (cbSexo.SelectedIndex == 1) sexo = 'F';
			objMiembro.Sexo = sexo;
			objMiembro.TallaDeCamisa = (cbTallaDeCamisa.SelectedItem.ToString());

			if (!txtNombre.Text.Equals(""))
			{
				if (new DaoMiembro().UPDATE(objMiembro))
				{
					MessageBox.Show("Datos Actualizados correctamente");
					limpiarCampos();
					TraerDatos();
				}
				else
				{
					MessageBox.Show("Error al actualizar");

				}
			}
			else
			{
				MessageBox.Show("El nombre no puede estar vacio");
			}
		}

	}
}
