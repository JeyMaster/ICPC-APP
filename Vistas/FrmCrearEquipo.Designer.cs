namespace Vistas
{
    partial class FrmCrearEquipo
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAgregarIntegrante = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.cbRegiones = new System.Windows.Forms.ComboBox();
			this.cbSedes = new System.Windows.Forms.ComboBox();
			this.cbConcursos = new System.Windows.Forms.ComboBox();
			this.cbInstituciones = new System.Windows.Forms.ComboBox();
			this.txtNombreEquipo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbIntegrante = new System.Windows.Forms.ComboBox();
			this.cbRol = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecionar Region: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(296, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seleccionar Sede:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Seleccionar Concurso: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Seleccionar Institución:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(296, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ingresa El nombre del equipo";
			// 
			// btnAgregarIntegrante
			// 
			this.btnAgregarIntegrante.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAgregarIntegrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnAgregarIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarIntegrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarIntegrante.ForeColor = System.Drawing.Color.White;
			this.btnAgregarIntegrante.Location = new System.Drawing.Point(374, 263);
			this.btnAgregarIntegrante.Name = "btnAgregarIntegrante";
			this.btnAgregarIntegrante.Size = new System.Drawing.Size(202, 35);
			this.btnAgregarIntegrante.TabIndex = 8;
			this.btnAgregarIntegrante.Text = "Agregar Integrante";
			this.btnAgregarIntegrante.UseVisualStyleBackColor = true;
			this.btnAgregarIntegrante.Click += new System.EventHandler(this.btnAgregarIntegrante_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.White;
			this.btnAgregar.Location = new System.Drawing.Point(334, 558);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(242, 32);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Crear equipo";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// cbRegiones
			// 
			this.cbRegiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRegiones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRegiones.ForeColor = System.Drawing.Color.Black;
			this.cbRegiones.FormattingEnabled = true;
			this.cbRegiones.Location = new System.Drawing.Point(15, 30);
			this.cbRegiones.Name = "cbRegiones";
			this.cbRegiones.Size = new System.Drawing.Size(259, 26);
			this.cbRegiones.TabIndex = 0;
			this.cbRegiones.SelectedIndexChanged += new System.EventHandler(this.cbRegiones_SelectedIndexChanged);
			// 
			// cbSedes
			// 
			this.cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSedes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSedes.ForeColor = System.Drawing.Color.Black;
			this.cbSedes.FormattingEnabled = true;
			this.cbSedes.Location = new System.Drawing.Point(299, 30);
			this.cbSedes.Name = "cbSedes";
			this.cbSedes.Size = new System.Drawing.Size(277, 26);
			this.cbSedes.TabIndex = 1;
			this.cbSedes.SelectedIndexChanged += new System.EventHandler(this.cbSedes_SelectedIndexChanged);
			// 
			// cbConcursos
			// 
			this.cbConcursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbConcursos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbConcursos.ForeColor = System.Drawing.Color.Black;
			this.cbConcursos.FormattingEnabled = true;
			this.cbConcursos.Location = new System.Drawing.Point(15, 167);
			this.cbConcursos.Name = "cbConcursos";
			this.cbConcursos.Size = new System.Drawing.Size(259, 26);
			this.cbConcursos.TabIndex = 4;
			// 
			// cbInstituciones
			// 
			this.cbInstituciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbInstituciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbInstituciones.ForeColor = System.Drawing.Color.Black;
			this.cbInstituciones.FormattingEnabled = true;
			this.cbInstituciones.Location = new System.Drawing.Point(15, 96);
			this.cbInstituciones.Name = "cbInstituciones";
			this.cbInstituciones.Size = new System.Drawing.Size(259, 26);
			this.cbInstituciones.TabIndex = 2;
			// 
			// txtNombreEquipo
			// 
			this.txtNombreEquipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreEquipo.ForeColor = System.Drawing.Color.Black;
			this.txtNombreEquipo.Location = new System.Drawing.Point(299, 167);
			this.txtNombreEquipo.Name = "txtNombreEquipo";
			this.txtNombreEquipo.Size = new System.Drawing.Size(277, 26);
			this.txtNombreEquipo.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(296, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 18);
			this.label6.TabIndex = 17;
			this.label6.Text = "Fecha de registro";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(447, 96);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(102, 26);
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.Value = new System.DateTime(2019, 11, 25, 16, 51, 28, 0);
			// 
			// cbIntegrante
			// 
			this.cbIntegrante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbIntegrante.FormattingEnabled = true;
			this.cbIntegrante.Location = new System.Drawing.Point(105, 228);
			this.cbIntegrante.Name = "cbIntegrante";
			this.cbIntegrante.Size = new System.Drawing.Size(238, 26);
			this.cbIntegrante.TabIndex = 6;
			this.cbIntegrante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbIntegrante_KeyUp);
			// 
			// cbRol
			// 
			this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRol.FormattingEnabled = true;
			this.cbRol.Items.AddRange(new object[] {
            "Couch",
            "Co-Couch",
            "Participante",
            "Reserva"});
			this.cbRol.Location = new System.Drawing.Point(105, 272);
			this.cbRol.Name = "cbRol";
			this.cbRol.Size = new System.Drawing.Size(128, 26);
			this.cbRol.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(19, 231);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 18);
			this.label7.TabIndex = 21;
			this.label7.Text = "Usuario";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(50, 275);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 18);
			this.label8.TabIndex = 22;
			this.label8.Text = "Rol";
			// 
			// btnEditar
			// 
			this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.White;
			this.btnEditar.Location = new System.Drawing.Point(435, 379);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(141, 35);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(435, 420);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(141, 35);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// dgvIntegrantes
			// 
			this.dgvIntegrantes.AllowUserToAddRows = false;
			this.dgvIntegrantes.AllowUserToDeleteRows = false;
			this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIntegrantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmail,
            this.colRol});
			this.dgvIntegrantes.Location = new System.Drawing.Point(22, 322);
			this.dgvIntegrantes.Name = "dgvIntegrantes";
			this.dgvIntegrantes.ReadOnly = true;
			this.dgvIntegrantes.Size = new System.Drawing.Size(392, 209);
			this.dgvIntegrantes.TabIndex = 25;
			this.dgvIntegrantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIntegrantes_CellClick_1);
			// 
			// colEmail
			// 
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.ReadOnly = true;
			this.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colEmail.Width = 240;
			// 
			// colRol
			// 
			this.colRol.DataPropertyName = "Rol";
			this.colRol.HeaderText = "Rol";
			this.colRol.Name = "colRol";
			this.colRol.ReadOnly = true;
			this.colRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// FrmCrearEquipo
			// 
			this.AcceptButton = this.btnAgregarIntegrante;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(620, 611);
			this.Controls.Add(this.dgvIntegrantes);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbRol);
			this.Controls.Add(this.cbIntegrante);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNombreEquipo);
			this.Controls.Add(this.cbInstituciones);
			this.Controls.Add(this.cbConcursos);
			this.Controls.Add(this.cbSedes);
			this.Controls.Add(this.cbRegiones);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnAgregarIntegrante);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmCrearEquipo";
			this.Text = "FrmCrearEquipo";
			this.Load += new System.EventHandler(this.FrmCrearEquipo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarIntegrante;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbRegiones;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.ComboBox cbConcursos;
        private System.Windows.Forms.ComboBox cbInstituciones;
        private System.Windows.Forms.TextBox txtNombreEquipo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbIntegrante;
		private System.Windows.Forms.ComboBox cbRol;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dgvIntegrantes;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
	}
}