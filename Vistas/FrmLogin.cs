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
using System.Text.RegularExpressions;

namespace Vistas
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
            InitializeComponent();
		}

		private Regex automata;
		public static Miembro user;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

			if (Validaciones(Strings.validarCorreo, txtEmail, "Email incorrecto")
				&Validaciones(Strings.alfaNumerico,txtContrasena,"Solo valores alfanumericos"))
			{
				if (txtEmail.Text == Strings.ADMIN && txtContrasena.Text == Strings.PASS)
				{
					new FrmTableroAdministrador().ShowDialog();
					clearTextBoxes();
				}
				else
				{
					Miembro objMiembro = new Miembro();
					objMiembro.Email = txtEmail.Text;
					objMiembro.Contrasenia = txtContrasena.Text;

					objMiembro = new DaoMiembro().SELECT_TO_LOGIN(objMiembro);
					if (objMiembro!=null)
					{
						user = objMiembro;
						new FrmTableroMiembro().ShowDialog();
						clearTextBoxes();
					}
					else
					{
						MessageBox.Show("Usuario o contraseña incorrectos");
					}
				}

			}
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            new FrmRegistro().ShowDialog();
        }


		private void clearTextBoxes()
		{
			txtEmail.Text = "";
			txtContrasena.Text = "";
		}

		private bool Validaciones(String validacion,TextBox txtComponent,String msg)
		{
			bool done = false;
			automata = new Regex(validacion);
			if (!automata.IsMatch(txtComponent.Text))
			{
				errPrvLogin.SetError(txtComponent, msg);
				done = false;
			}
			else
			{
				errPrvLogin.SetError(txtComponent, "");
				done = true;
			}

			return done;
		}
	}
}
