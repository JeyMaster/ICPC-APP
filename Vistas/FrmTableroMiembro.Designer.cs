namespace Vistas
{
    partial class FrmTableroMiembro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnMenu = new System.Windows.Forms.Panel();
			this.lblNombre = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAdminEquipos = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCrearEquipo = new System.Windows.Forms.Button();
			this.btnPerfil = new System.Windows.Forms.Button();
			this.pnContenedor = new System.Windows.Forms.Panel();
			this.pnMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.pnMenu.Controls.Add(this.lblNombre);
			this.pnMenu.Controls.Add(this.button1);
			this.pnMenu.Controls.Add(this.btnAdminEquipos);
			this.pnMenu.Controls.Add(this.label1);
			this.pnMenu.Controls.Add(this.btnCrearEquipo);
			this.pnMenu.Controls.Add(this.btnPerfil);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMenu.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(175, 567);
			this.pnMenu.TabIndex = 0;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(24, 69);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(54, 19);
			this.lblNombre.TabIndex = 5;
			this.lblNombre.Text = "label2";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkViolet;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(28, 516);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "Cerrar sesion";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdminEquipos
			// 
			this.btnAdminEquipos.BackColor = System.Drawing.Color.BlueViolet;
			this.btnAdminEquipos.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAdminEquipos.FlatAppearance.BorderSize = 0;
			this.btnAdminEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnAdminEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminEquipos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdminEquipos.ForeColor = System.Drawing.Color.White;
			this.btnAdminEquipos.Location = new System.Drawing.Point(0, 198);
			this.btnAdminEquipos.Name = "btnAdminEquipos";
			this.btnAdminEquipos.Size = new System.Drawing.Size(175, 37);
			this.btnAdminEquipos.TabIndex = 3;
			this.btnAdminEquipos.Text = "Administrar Equipos        ";
			this.btnAdminEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdminEquipos.UseVisualStyleBackColor = false;
			this.btnAdminEquipos.Click += new System.EventHandler(this.btnAdminEquipos_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "Bienvenido";
			// 
			// btnCrearEquipo
			// 
			this.btnCrearEquipo.BackColor = System.Drawing.Color.BlueViolet;
			this.btnCrearEquipo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnCrearEquipo.FlatAppearance.BorderSize = 0;
			this.btnCrearEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnCrearEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrearEquipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrearEquipo.ForeColor = System.Drawing.Color.White;
			this.btnCrearEquipo.Location = new System.Drawing.Point(0, 161);
			this.btnCrearEquipo.Name = "btnCrearEquipo";
			this.btnCrearEquipo.Size = new System.Drawing.Size(175, 37);
			this.btnCrearEquipo.TabIndex = 1;
			this.btnCrearEquipo.Text = "Crear Equipo  ";
			this.btnCrearEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCrearEquipo.UseVisualStyleBackColor = false;
			this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
			// 
			// btnPerfil
			// 
			this.btnPerfil.BackColor = System.Drawing.Color.BlueViolet;
			this.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnPerfil.FlatAppearance.BorderSize = 0;
			this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPerfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPerfil.ForeColor = System.Drawing.Color.White;
			this.btnPerfil.Location = new System.Drawing.Point(0, 127);
			this.btnPerfil.Name = "btnPerfil";
			this.btnPerfil.Size = new System.Drawing.Size(175, 37);
			this.btnPerfil.TabIndex = 0;
			this.btnPerfil.Text = "Perfil  ";
			this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPerfil.UseVisualStyleBackColor = false;
			this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
			// 
			// pnContenedor
			// 
			this.pnContenedor.AutoScroll = true;
			this.pnContenedor.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnContenedor.Location = new System.Drawing.Point(175, 0);
			this.pnContenedor.Name = "pnContenedor";
			this.pnContenedor.Size = new System.Drawing.Size(822, 567);
			this.pnContenedor.TabIndex = 1;
			// 
			// FrmTableroMiembro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(997, 567);
			this.Controls.Add(this.pnContenedor);
			this.Controls.Add(this.pnMenu);
			this.Name = "FrmTableroMiembro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTableroMiembro";
			this.pnMenu.ResumeLayout(false);
			this.pnMenu.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminEquipos;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button button1;
	}
}