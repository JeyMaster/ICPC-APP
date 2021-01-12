namespace Vistas
{
    partial class FrmTableroAdministrador
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdminInstituciones = new System.Windows.Forms.Button();
			this.btnAdminConcursos = new System.Windows.Forms.Button();
			this.btnAdminSedes = new System.Windows.Forms.Button();
			this.btnAdminRegiones = new System.Windows.Forms.Button();
			this.pnContenedor = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnReporteInstitucion = new System.Windows.Forms.Button();
			this.btnReporteRegion = new System.Windows.Forms.Button();
			this.btnReporteIntegrante = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnSalir);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAdminInstituciones);
			this.panel1.Controls.Add(this.btnAdminConcursos);
			this.panel1.Controls.Add(this.btnAdminSedes);
			this.panel1.Controls.Add(this.btnAdminRegiones);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(203, 511);
			this.panel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(24, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "\"Administrador\"";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
			this.btnSalir.FlatAppearance.BorderSize = 0;
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(50, 453);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(105, 37);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(41, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Bienvenido ";
			// 
			// btnAdminInstituciones
			// 
			this.btnAdminInstituciones.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdminInstituciones.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnAdminInstituciones.FlatAppearance.BorderSize = 0;
			this.btnAdminInstituciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnAdminInstituciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminInstituciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdminInstituciones.ForeColor = System.Drawing.Color.White;
			this.btnAdminInstituciones.Location = new System.Drawing.Point(8, 212);
			this.btnAdminInstituciones.Name = "btnAdminInstituciones";
			this.btnAdminInstituciones.Size = new System.Drawing.Size(195, 43);
			this.btnAdminInstituciones.TabIndex = 3;
			this.btnAdminInstituciones.Text = "Instituciones  ";
			this.btnAdminInstituciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdminInstituciones.UseVisualStyleBackColor = false;
			this.btnAdminInstituciones.Click += new System.EventHandler(this.btnAdminInstituciones_Click);
			// 
			// btnAdminConcursos
			// 
			this.btnAdminConcursos.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdminConcursos.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnAdminConcursos.FlatAppearance.BorderSize = 0;
			this.btnAdminConcursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnAdminConcursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminConcursos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdminConcursos.ForeColor = System.Drawing.Color.White;
			this.btnAdminConcursos.Location = new System.Drawing.Point(8, 169);
			this.btnAdminConcursos.Name = "btnAdminConcursos";
			this.btnAdminConcursos.Size = new System.Drawing.Size(195, 43);
			this.btnAdminConcursos.TabIndex = 2;
			this.btnAdminConcursos.Text = "Concursos  ";
			this.btnAdminConcursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdminConcursos.UseVisualStyleBackColor = false;
			this.btnAdminConcursos.Click += new System.EventHandler(this.btnAdminConcursos_Click);
			// 
			// btnAdminSedes
			// 
			this.btnAdminSedes.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdminSedes.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnAdminSedes.FlatAppearance.BorderSize = 0;
			this.btnAdminSedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnAdminSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminSedes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdminSedes.ForeColor = System.Drawing.Color.White;
			this.btnAdminSedes.Location = new System.Drawing.Point(8, 126);
			this.btnAdminSedes.Name = "btnAdminSedes";
			this.btnAdminSedes.Size = new System.Drawing.Size(195, 43);
			this.btnAdminSedes.TabIndex = 1;
			this.btnAdminSedes.Text = "Sedes  ";
			this.btnAdminSedes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdminSedes.UseVisualStyleBackColor = false;
			this.btnAdminSedes.Click += new System.EventHandler(this.btnAdminSedes_Click);
			// 
			// btnAdminRegiones
			// 
			this.btnAdminRegiones.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAdminRegiones.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnAdminRegiones.FlatAppearance.BorderSize = 0;
			this.btnAdminRegiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnAdminRegiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdminRegiones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdminRegiones.ForeColor = System.Drawing.Color.White;
			this.btnAdminRegiones.Location = new System.Drawing.Point(8, 83);
			this.btnAdminRegiones.Name = "btnAdminRegiones";
			this.btnAdminRegiones.Size = new System.Drawing.Size(195, 43);
			this.btnAdminRegiones.TabIndex = 0;
			this.btnAdminRegiones.Text = "Regiones  ";
			this.btnAdminRegiones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdminRegiones.UseVisualStyleBackColor = false;
			this.btnAdminRegiones.Click += new System.EventHandler(this.btnAdminRegiones_Click);
			// 
			// pnContenedor
			// 
			this.pnContenedor.BackColor = System.Drawing.Color.SeaGreen;
			this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnContenedor.Location = new System.Drawing.Point(203, 0);
			this.pnContenedor.Name = "pnContenedor";
			this.pnContenedor.Size = new System.Drawing.Size(731, 511);
			this.pnContenedor.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.ForestGreen;
			this.panel2.Controls.Add(this.btnReporteInstitucion);
			this.panel2.Controls.Add(this.btnReporteRegion);
			this.panel2.Controls.Add(this.btnReporteIntegrante);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(203, 453);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(731, 58);
			this.panel2.TabIndex = 2;
			// 
			// btnReporteInstitucion
			// 
			this.btnReporteInstitucion.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnReporteInstitucion.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnReporteInstitucion.FlatAppearance.BorderSize = 0;
			this.btnReporteInstitucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnReporteInstitucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReporteInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteInstitucion.ForeColor = System.Drawing.Color.White;
			this.btnReporteInstitucion.Location = new System.Drawing.Point(517, 8);
			this.btnReporteInstitucion.Name = "btnReporteInstitucion";
			this.btnReporteInstitucion.Size = new System.Drawing.Size(176, 43);
			this.btnReporteInstitucion.TabIndex = 3;
			this.btnReporteInstitucion.Text = "Por institución";
			this.btnReporteInstitucion.UseVisualStyleBackColor = false;
			this.btnReporteInstitucion.Click += new System.EventHandler(this.btnReporteInstitucion_Click);
			// 
			// btnReporteRegion
			// 
			this.btnReporteRegion.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnReporteRegion.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnReporteRegion.FlatAppearance.BorderSize = 0;
			this.btnReporteRegion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnReporteRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReporteRegion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteRegion.ForeColor = System.Drawing.Color.White;
			this.btnReporteRegion.Location = new System.Drawing.Point(327, 8);
			this.btnReporteRegion.Name = "btnReporteRegion";
			this.btnReporteRegion.Size = new System.Drawing.Size(159, 43);
			this.btnReporteRegion.TabIndex = 2;
			this.btnReporteRegion.Text = "Por region";
			this.btnReporteRegion.UseVisualStyleBackColor = false;
			this.btnReporteRegion.Click += new System.EventHandler(this.btnReporteRegion_Click);
			// 
			// btnReporteIntegrante
			// 
			this.btnReporteIntegrante.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnReporteIntegrante.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnReporteIntegrante.FlatAppearance.BorderSize = 0;
			this.btnReporteIntegrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnReporteIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReporteIntegrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporteIntegrante.ForeColor = System.Drawing.Color.White;
			this.btnReporteIntegrante.Location = new System.Drawing.Point(142, 8);
			this.btnReporteIntegrante.Name = "btnReporteIntegrante";
			this.btnReporteIntegrante.Size = new System.Drawing.Size(147, 43);
			this.btnReporteIntegrante.TabIndex = 1;
			this.btnReporteIntegrante.Text = "Equipos por sede";
			this.btnReporteIntegrante.UseVisualStyleBackColor = false;
			this.btnReporteIntegrante.Click += new System.EventHandler(this.btnReporteIntegrante_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(36, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Reportes";
			// 
			// FrmTableroAdministrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 511);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnContenedor);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(950, 550);
			this.Name = "FrmTableroAdministrador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmTableroAdministrador";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminInstituciones;
        private System.Windows.Forms.Button btnAdminConcursos;
        private System.Windows.Forms.Button btnAdminSedes;
        private System.Windows.Forms.Button btnAdminRegiones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnReporteInstitucion;
		private System.Windows.Forms.Button btnReporteRegion;
		private System.Windows.Forms.Button btnReporteIntegrante;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}