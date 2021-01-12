namespace Vistas
{
    partial class FrmEquiposMiembro
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
			this.dgvEquipos = new System.Windows.Forms.DataGridView();
			this.btnMostrarIntegrantes = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cboAnio = new System.Windows.Forms.ComboBox();
			this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
			this.lblInte = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(31, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 18);
			this.label1.TabIndex = 18;
			this.label1.Text = "Equipos";
			// 
			// dgvEquipos
			// 
			this.dgvEquipos.AllowUserToAddRows = false;
			this.dgvEquipos.AllowUserToDeleteRows = false;
			this.dgvEquipos.BackgroundColor = System.Drawing.Color.BlueViolet;
			this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipos.GridColor = System.Drawing.Color.BlueViolet;
			this.dgvEquipos.Location = new System.Drawing.Point(21, 71);
			this.dgvEquipos.Name = "dgvEquipos";
			this.dgvEquipos.ReadOnly = true;
			this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEquipos.Size = new System.Drawing.Size(676, 319);
			this.dgvEquipos.TabIndex = 15;
			this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);
			// 
			// btnMostrarIntegrantes
			// 
			this.btnMostrarIntegrantes.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnMostrarIntegrantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
			this.btnMostrarIntegrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarIntegrantes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarIntegrantes.ForeColor = System.Drawing.Color.White;
			this.btnMostrarIntegrantes.Location = new System.Drawing.Point(476, 418);
			this.btnMostrarIntegrantes.Name = "btnMostrarIntegrantes";
			this.btnMostrarIntegrantes.Size = new System.Drawing.Size(190, 30);
			this.btnMostrarIntegrantes.TabIndex = 2;
			this.btnMostrarIntegrantes.Text = "Mostrar integrantes";
			this.btnMostrarIntegrantes.UseVisualStyleBackColor = true;
			this.btnMostrarIntegrantes.Click += new System.EventHandler(this.btnMostrarIntegrantes_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(528, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 18);
			this.label2.TabIndex = 20;
			this.label2.Text = "Año";
			// 
			// cboAnio
			// 
			this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAnio.FormattingEnabled = true;
			this.cboAnio.Location = new System.Drawing.Point(582, 33);
			this.cboAnio.Name = "cboAnio";
			this.cboAnio.Size = new System.Drawing.Size(104, 21);
			this.cboAnio.TabIndex = 1;
			this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
			// 
			// dgvIntegrantes
			// 
			this.dgvIntegrantes.AllowUserToAddRows = false;
			this.dgvIntegrantes.AllowUserToDeleteRows = false;
			this.dgvIntegrantes.BackgroundColor = System.Drawing.Color.BlueViolet;
			this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIntegrantes.Location = new System.Drawing.Point(21, 496);
			this.dgvIntegrantes.Name = "dgvIntegrantes";
			this.dgvIntegrantes.ReadOnly = true;
			this.dgvIntegrantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvIntegrantes.Size = new System.Drawing.Size(676, 191);
			this.dgvIntegrantes.TabIndex = 21;
			this.dgvIntegrantes.Visible = false;
			// 
			// lblInte
			// 
			this.lblInte.AutoSize = true;
			this.lblInte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInte.ForeColor = System.Drawing.Color.White;
			this.lblInte.Location = new System.Drawing.Point(31, 460);
			this.lblInte.Name = "lblInte";
			this.lblInte.Size = new System.Drawing.Size(84, 18);
			this.lblInte.TabIndex = 22;
			this.lblInte.Text = "Integrantes";
			this.lblInte.Visible = false;
			// 
			// FrmEquiposMiembro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(720, 699);
			this.Controls.Add(this.lblInte);
			this.Controls.Add(this.dgvIntegrantes);
			this.Controls.Add(this.cboAnio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMostrarIntegrantes);
			this.Controls.Add(this.dgvEquipos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEquiposMiembro";
			this.Text = "FrmAdminEquipos";
			this.Load += new System.EventHandler(this.FrmEquiposMiembro_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEquipos;
		private System.Windows.Forms.Button btnMostrarIntegrantes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboAnio;
		private System.Windows.Forms.DataGridView dgvIntegrantes;
		private System.Windows.Forms.Label lblInte;
	}
}