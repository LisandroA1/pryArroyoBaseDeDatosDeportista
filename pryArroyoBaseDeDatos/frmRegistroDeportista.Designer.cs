namespace pryArroyoBaseDeDatos
{
    partial class frmRegistroDeportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeportista));
            this.cmdRegistroDeportistas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoDeportista = new System.Windows.Forms.TextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.mskTelfonoDeportista = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoRegistroDeportista = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRegistroDeportistas
            // 
            this.cmdRegistroDeportistas.Enabled = false;
            this.cmdRegistroDeportistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroDeportistas.Location = new System.Drawing.Point(242, 373);
            this.cmdRegistroDeportistas.Name = "cmdRegistroDeportistas";
            this.cmdRegistroDeportistas.Size = new System.Drawing.Size(135, 33);
            this.cmdRegistroDeportistas.TabIndex = 33;
            this.cmdRegistroDeportistas.Text = "Registrar";
            this.cmdRegistroDeportistas.UseVisualStyleBackColor = true;
            this.cmdRegistroDeportistas.Click += new System.EventHandler(this.cmdRegistroDeportistas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Registro  Deportistas";
            // 
            // txtCodigoDeportista
            // 
            this.txtCodigoDeportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDeportista.Location = new System.Drawing.Point(198, 61);
            this.txtCodigoDeportista.MaxLength = 5;
            this.txtCodigoDeportista.Name = "txtCodigoDeportista";
            this.txtCodigoDeportista.Size = new System.Drawing.Size(181, 26);
            this.txtCodigoDeportista.TabIndex = 31;
            this.txtCodigoDeportista.TextChanged += new System.EventHandler(this.txtCodigoDeportista_TextChanged);
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDeportista.Location = new System.Drawing.Point(198, 151);
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.Size = new System.Drawing.Size(181, 26);
            this.txtApellidoDeportista.TabIndex = 29;
            this.txtApellidoDeportista.TextChanged += new System.EventHandler(this.txtApellidoDeportista_TextChanged);
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionDeportista.Location = new System.Drawing.Point(198, 196);
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.Size = new System.Drawing.Size(181, 26);
            this.txtDireccionDeportista.TabIndex = 28;
            this.txtDireccionDeportista.TextChanged += new System.EventHandler(this.txtDireccionDeportista_TextChanged);
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeportista.Location = new System.Drawing.Point(198, 106);
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.Size = new System.Drawing.Size(181, 26);
            this.txtNombreDeportista.TabIndex = 27;
            this.txtNombreDeportista.TextChanged += new System.EventHandler(this.txtNombreDeportista_TextChanged);
            // 
            // mskTelfonoDeportista
            // 
            this.mskTelfonoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelfonoDeportista.Location = new System.Drawing.Point(198, 241);
            this.mskTelfonoDeportista.Name = "mskTelfonoDeportista";
            this.mskTelfonoDeportista.Size = new System.Drawing.Size(181, 26);
            this.mskTelfonoDeportista.TabIndex = 25;
            this.mskTelfonoDeportista.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelfonoDeportista_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Deporte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo deportista";
            // 
            // txtDeporte
            // 
            this.txtDeporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeporte.Location = new System.Drawing.Point(198, 331);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(181, 26);
            this.txtDeporte.TabIndex = 34;
            this.txtDeporte.TextChanged += new System.EventHandler(this.txtDeporte_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(198, 286);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(181, 26);
            this.txtEdad.TabIndex = 35;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoRegistroDeportista});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(401, 22);
            this.statusStrip1.TabIndex = 36;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblEstadoRegistroDeportista
            // 
            this.lblEstadoRegistroDeportista.Name = "lblEstadoRegistroDeportista";
            this.lblEstadoRegistroDeportista.Size = new System.Drawing.Size(12, 17);
            this.lblEstadoRegistroDeportista.Text = "-";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(91, 373);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(135, 33);
            this.cmdCancelar.TabIndex = 37;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmRegistroDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 436);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDeporte);
            this.Controls.Add(this.cmdRegistroDeportistas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoDeportista);
            this.Controls.Add(this.txtApellidoDeportista);
            this.Controls.Add(this.txtDireccionDeportista);
            this.Controls.Add(this.txtNombreDeportista);
            this.Controls.Add(this.mskTelfonoDeportista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroDeportista";
            this.Load += new System.EventHandler(this.frmRegistroDeportista_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistroDeportistas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.MaskedTextBox mskTelfonoDeportista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoRegistroDeportista;
        private System.Windows.Forms.Button cmdCancelar;
    }
}