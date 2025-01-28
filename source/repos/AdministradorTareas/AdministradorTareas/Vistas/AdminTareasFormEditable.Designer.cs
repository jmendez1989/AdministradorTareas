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
            this.lblDescription.Location = new System.Drawing.Point(20, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descripción:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 60);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(340, 23);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(120, 100);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(340, 23);
            this.cmbEstado.TabIndex = 5;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(20, 140);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(58, 15);
            this.lblPrioridad.TabIndex = 6;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Location = new System.Drawing.Point(120, 140);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(340, 23);
            this.cmbPrioridad.TabIndex = 7;
            // 
            // lblFechaCompromiso
            // 
            this.lblFechaCompromiso.AutoSize = true;
            this.lblFechaCompromiso.Location = new System.Drawing.Point(20, 180);
            this.lblFechaCompromiso.Name = "lblFechaCompromiso";
            this.lblFechaCompromiso.Size = new System.Drawing.Size(77, 15);
            this.lblFechaCompromiso.TabIndex = 8;
            this.lblFechaCompromiso.Text = "Fecha Límite:";
            // 
            // dtpFechaCompromiso
            // 
            this.dtpFechaCompromiso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompromiso.Location = new System.Drawing.Point(120, 180);
            this.dtpFechaCompromiso.Name = "dtpFechaCompromiso";
            this.dtpFechaCompromiso.Size = new System.Drawing.Size(340, 23);
            this.dtpFechaCompromiso.TabIndex = 9;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(20, 220);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(41, 15);
            this.lblNotas.TabIndex = 10;
            this.lblNotas.Text = "Notas:";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(120, 220);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(340, 80);
            this.txtNotas.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.Location = new System.Drawing.Point(120, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelar.Location = new System.Drawing.Point(260, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AdminTareasFormEditable
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblFechaCompromiso);
            this.Controls.Add(this.dtpFechaCompromiso);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminTareasFormEditable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Tareas";
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
