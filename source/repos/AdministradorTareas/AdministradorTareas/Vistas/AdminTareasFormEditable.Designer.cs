namespace AdministradorTareas
{
    partial class AdminTareasFormEditable
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblFechaCompromiso = new System.Windows.Forms.Label();
            this.dtpFechaCompromiso = new System.Windows.Forms.DateTimePicker();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 17);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripción:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 14);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(291, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 52);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 49);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(291, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(14, 87);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(117, 83);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(291, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(14, 121);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(58, 15);
            this.lblPrioridad.TabIndex = 6;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(117, 118);
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(291, 23);
            this.cmbPrioridad.TabIndex = 7;
            // 
            // lblFechaCompromiso
            // 
            this.lblFechaCompromiso.AutoSize = true;
            this.lblFechaCompromiso.Location = new System.Drawing.Point(14, 156);
            this.lblFechaCompromiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaCompromiso.Name = "lblFechaCompromiso";
            this.lblFechaCompromiso.Size = new System.Drawing.Size(77, 15);
            this.lblFechaCompromiso.TabIndex = 8;
            this.lblFechaCompromiso.Text = "Fecha Límite:";
            // 
            // dtpFechaCompromiso
            // 
            this.dtpFechaCompromiso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompromiso.Location = new System.Drawing.Point(117, 152);
            this.dtpFechaCompromiso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaCompromiso.Name = "dtpFechaCompromiso";
            this.dtpFechaCompromiso.Size = new System.Drawing.Size(291, 23);
            this.dtpFechaCompromiso.TabIndex = 9;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(14, 190);
            this.lblNotas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(41, 15);
            this.lblNotas.TabIndex = 10;
            this.lblNotas.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(117, 187);
            this.txtNotas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(291, 69);
            this.txtNotas.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(117, 277);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 27);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(321, 277);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AdminTareasFormEditable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 324);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.dtpFechaCompromiso);
            this.Controls.Add(this.lblFechaCompromiso);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminTareasFormEditable";
            this.Text = "Mantenimiento Tareas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblFechaCompromiso;
        private System.Windows.Forms.DateTimePicker dtpFechaCompromiso;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

        #endregion
    }
}