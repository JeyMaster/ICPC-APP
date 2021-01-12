using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAOS;

namespace Vistas
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

		Regex automata;

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
			bool email=Validaciones(Strings.validarCorreo,txtEmail,"Email no valido");
			bool nombre=Validaciones(Strings.Nombres,txtNombre,"Formato de nombre no valido");
			bool apellido= Validaciones(Strings.Nombres, txtApellido, "Formato de apellidos no valido");
			bool contrasenia= Validaciones(Strings.alfaNumerico, txtContraseña, "Solo valores alfanumericos");

			if (email&nombre&apellido&contrasenia)
			{
				if (txtContraseña.Text==txtRcontraseña.Text)
				{
					errPrvRegistro.SetError(txtRcontraseña, "");

					Miembro objMiembro = new Miembro(txtEmail.Text,txtNombre.Text,txtApellido.Text,txtRcontraseña.Text);
					int done = new DaoMiembro().INSERT(objMiembro);

					if (done>=0)
					{
						MessageBox.Show("Usuario registrado con exito");
						clearTextBoxes();
					}
					else
					{
						MessageBox.Show("Error al registrar reintente");
					}
				}
				else
				{
					errPrvRegistro.SetError(txtRcontraseña, "Las contraseñas no coinciden");

				}
			}
			
        }

		private bool Validaciones(String validacion, TextBox txtComponent, String msg)
		{
			bool done = false;
			automata = new Regex(validacion);
			if (!automata.IsMatch(txtComponent.Text))
			{
				errPrvRegistro.SetError(txtComponent, msg);
				done = false;
			}
			else
			{
				errPrvRegistro.SetError(txtComponent, "");
				done = true;
			}

			return done;
		}

		public void clearTextBoxes()
		{
			txtEmail.Text = "";
			txtNombre.Text = "";
			txtApellido.Text = "";
			txtContraseña.Text = "";
			txtRcontraseña.Text = "";
		}
	}
}
