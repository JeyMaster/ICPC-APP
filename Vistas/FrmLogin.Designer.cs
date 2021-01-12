namespace Vistas
{
	partial class FrmLogin
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.btnRegistrarse = new System.Windows.Forms.Button();
			this.btnIniciarSesion = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.errPrvLogin = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errPrvLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(59, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(59, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(62, 160);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(244, 26);
			this.txtEmail.TabIndex = 1;
			this.txtEmail.Text = "admin@admin.com";
			// 
			// txtContrasena
			// 
			this.txtContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.Location = new System.Drawing.Point(62, 254);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(244, 26);
			this.txtContrasena.TabIndex = 2;
			this.txtContrasena.Text = "admin";
			// 
			// btnRegistrarse
			// 
			this.btnRegistrarse.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
			this.btnRegistrarse.Location = new System.Drawing.Point(62, 351);
			this.btnRegistrarse.Name = "btnRegistrarse";
			this.btnRegistrarse.Size = new System.Drawing.Size(244, 35);
			this.btnRegistrarse.TabIndex = 4;
			this.btnRegistrarse.Text = "Registrarse";
			this.btnRegistrarse.UseVisualStyleBackColor = false;
			this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.BackColor = System.Drawing.Color.MidnightBlue;
			this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
			this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
			this.btnIniciarSesion.Location = new System.Drawing.Point(62, 307);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.Size = new System.Drawing.Size(244, 35);
			this.btnIniciarSesion.TabIndex = 3;
			this.btnIniciarSesion.Text = "Iniciar Sesión";
			this.btnIniciarSesion.UseVisualStyleBackColor = false;
			this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Vistas.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(202, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 84);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(56, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 33);
			this.label3.TabIndex = 8;
			this.label3.Text = "Acceso";
			// 
			// errPrvLogin
			// 
			this.errPrvLogin.ContainerControl = this;
			// 
			// FrmLogin
			// 
			this.AcceptButton = this.btnIniciarSesion;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(362, 436);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnIniciarSesion);
			this.Controls.Add(this.btnRegistrarse);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errPrvLogin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIniciarSesion;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider errPrvLogin;
	}
}

