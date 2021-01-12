namespace Vistas
{
    partial class FrmAgregarEditarSedes
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
			this.components = new System.ComponentModel.Container();
			this.lblIdSede = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblIdRegion = new System.Windows.Forms.Label();
			this.txtIdSede = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardarCambios = new System.Windows.Forms.Button();
			this.cbIdRegion = new System.Windows.Forms.ComboBox();
			this.errPSedes = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errPSedes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIdSede
			// 
			this.lblIdSede.AutoSize = true;
			this.lblIdSede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdSede.ForeColor = System.Drawing.Color.White;
			this.lblIdSede.Location = new System.Drawing.Point(12, 9);
			this.lblIdSede.Name = "lblIdSede";
			this.lblIdSede.Size = new System.Drawing.Size(66, 18);
			this.lblIdSede.TabIndex = 0;
			this.lblIdSede.Text = "Id Sede:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombre.ForeColor = System.Drawing.Color.White;
			this.lblNombre.Location = new System.Drawing.Point(10, 73);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(68, 18);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblIdRegion
			// 
			this.lblIdRegion.AutoSize = true;
			this.lblIdRegion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdRegion.ForeColor = System.Drawing.Color.White;
			this.lblIdRegion.Location = new System.Drawing.Point(169, 9);
			this.lblIdRegion.Name = "lblIdRegion";
			this.lblIdRegion.Size = new System.Drawing.Size(78, 18);
			this.lblIdRegion.TabIndex = 2;
			this.lblIdRegion.Text = "Id Region:";
			// 
			// txtIdSede
			// 
			this.txtIdSede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdSede.Location = new System.Drawing.Point(12, 30);
			this.txtIdSede.Name = "txtIdSede";
			this.txtIdSede.Size = new System.Drawing.Size(100, 26);
			this.txtIdSede.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(12, 102);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(266, 26);
			this.txtNombre.TabIndex = 3;
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.White;
			this.btnCancelar.Location = new System.Drawing.Point(66, 168);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(100, 37);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardarCambios
			// 
			this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
			this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardarCambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
			this.btnGuardarCambios.Location = new System.Drawing.Point(189, 168);
			this.btnGuardarCambios.Name = "btnGuardarCambios";
			this.btnGuardarCambios.Size = new System.Drawing.Size(174, 37);
			this.btnGuardarCambios.TabIndex = 5;
			this.btnGuardarCambios.Text = "Guardar Cambios";
			this.btnGuardarCambios.UseVisualStyleBackColor = true;
			this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
			// 
			// cbIdRegion
			// 
			this.cbIdRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbIdRegion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbIdRegion.FormattingEnabled = true;
			this.cbIdRegion.Location = new System.Drawing.Point(168, 30);
			this.cbIdRegion.Name = "cbIdRegion";
			this.cbIdRegion.Size = new System.Drawing.Size(216, 26);
			this.cbIdRegion.TabIndex = 2;
			// 
			// errPSedes
			// 
			this.errPSedes.ContainerControl = this;
			// 
			// FrmAgregarEditarSedes
			// 
			this.AcceptButton = this.btnGuardarCambios;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(409, 226);
			this.Controls.Add(this.cbIdRegion);
			this.Controls.Add(this.btnGuardarCambios);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtIdSede);
			this.Controls.Add(this.lblIdRegion);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblIdSede);
			this.Name = "FrmAgregarEditarSedes";
			this.Text = "Agregar Editar Sedes";
			this.Load += new System.EventHandler(this.FrmAgregarEditarSedes_Load);
			((System.ComponentModel.ISupportInitialize)(this.errPSedes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdSede;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdRegion;
        private System.Windows.Forms.TextBox txtIdSede;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ComboBox cbIdRegion;
        private System.Windows.Forms.ErrorProvider errPSedes;
    }
}