namespace Vistas
{
	partial class FrmReporteRegion
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
			this.cboAnio = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnMostrarReporte = new System.Windows.Forms.Button();
			this.dgvReporte = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
			this.SuspendLayout();
			// 
			// cboAnio
			// 
			this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAnio.FormattingEnabled = true;
			this.cboAnio.Location = new System.Drawing.Point(623, 20);
			this.cboAnio.Name = "cboAnio";
			this.cboAnio.Size = new System.Drawing.Size(104, 21);
			this.cboAnio.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(569, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 18);
			this.label2.TabIndex = 28;
			this.label2.Text = "Año";
			// 
			// btnMostrarReporte
			// 
			this.btnMostrarReporte.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnMostrarReporte.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btnMostrarReporte.FlatAppearance.BorderSize = 0;
			this.btnMostrarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnMostrarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMostrarReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMostrarReporte.ForeColor = System.Drawing.Color.White;
			this.btnMostrarReporte.Location = new System.Drawing.Point(548, 401);
			this.btnMostrarReporte.Name = "btnMostrarReporte";
			this.btnMostrarReporte.Size = new System.Drawing.Size(190, 30);
			this.btnMostrarReporte.TabIndex = 26;
			this.btnMostrarReporte.Text = "Mostrar reporte";
			this.btnMostrarReporte.UseVisualStyleBackColor = false;
			this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
			// 
			// dgvReporte
			// 
			this.dgvReporte.AllowUserToAddRows = false;
			this.dgvReporte.AllowUserToDeleteRows = false;
			this.dgvReporte.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
			this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReporte.GridColor = System.Drawing.Color.BlueViolet;
			this.dgvReporte.Location = new System.Drawing.Point(62, 58);
			this.dgvReporte.Name = "dgvReporte";
			this.dgvReporte.ReadOnly = true;
			this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReporte.Size = new System.Drawing.Size(676, 319);
			this.dgvReporte.TabIndex = 27;
			// 
			// FrmReporteRegion
			// 
			this.AcceptButton = this.btnMostrarReporte;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboAnio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnMostrarReporte);
			this.Controls.Add(this.dgvReporte);
			this.Name = "FrmReporteRegion";
			this.Text = "FrmReporteRegion";
			this.Load += new System.EventHandler(this.FrmReporteRegion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboAnio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnMostrarReporte;
		private System.Windows.Forms.DataGridView dgvReporte;
	}
}