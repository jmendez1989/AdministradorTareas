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
            this.SuspendLayout();

            // Configuración de la ventana
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AdminTareasFormEditable";
            this.Text = "Gestión de Tareas";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Etiqueta Descripción
            var lblDescription = new System.Windows.Forms.Label();
            lblDescription.Text = "Descripción:";
            lblDescription.Location = new System.Drawing.Point(20, 20);
            lblDescription.AutoSize = true;
            this.Controls.Add(lblDescription);

            // Caja de texto Descripción
            var txtDescription = new System.Windows.Forms.TextBox();
            txtDescription.Location = new System.Drawing.Point(120, 20);
            txtDescription.Size = new System.Drawing.Size(340, 23);
            this.Controls.Add(txtDescription);

            // Etiqueta Usuario
            var lblUsuario = new System.Windows.Forms.Label();
            lblUsuario.Text = "Usuario:";
            lblUsuario.Location = new System.Drawing.Point(20, 60);
            lblUsuario.AutoSize = true;
            this.Controls.Add(lblUsuario);

            // Caja de texto Usuario
            var txtUsuario = new System.Windows.Forms.TextBox();
            txtUsuario.Location = new System.Drawing.Point(120, 60);
            txtUsuario.Size = new System.Drawing.Size(340, 23);
            this.Controls.Add(txtUsuario);

            // Etiqueta Estado
            var lblEstado = new System.Windows.Forms.Label();
            lblEstado.Text = "Estado:";
            lblEstado.Location = new System.Drawing.Point(20, 100);
            lblEstado.AutoSize = true;
            this.Controls.Add(lblEstado);

            // ComboBox Estado
            var cmbEstado = new System.Windows.Forms.ComboBox();
            cmbEstado.Location = new System.Drawing.Point(120, 100);
            cmbEstado.Size = new System.Drawing.Size(340, 23);
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbEstado);

            // Etiqueta Prioridad
            var lblPrioridad = new System.Windows.Forms.Label();
            lblPrioridad.Text = "Prioridad:";
            lblPrioridad.Location = new System.Drawing.Point(20, 140);
            lblPrioridad.AutoSize = true;
            this.Controls.Add(lblPrioridad);

            // ComboBox Prioridad
            var cmbPrioridad = new System.Windows.Forms.ComboBox();
            cmbPrioridad.Location = new System.Drawing.Point(120, 140);
            cmbPrioridad.Size = new System.Drawing.Size(340, 23);
            cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controls.Add(cmbPrioridad);

            // Etiqueta Fecha Límite
            var lblFechaCompromiso = new System.Windows.Forms.Label();
            lblFechaCompromiso.Text = "Fecha Límite:";
            lblFechaCompromiso.Location = new System.Drawing.Point(20, 180);
            lblFechaCompromiso.AutoSize = true;
            this.Controls.Add(lblFechaCompromiso);

            // DateTimePicker Fecha Límite
            var dtpFechaCompromiso = new System.Windows.Forms.DateTimePicker();
            dtpFechaCompromiso.Location = new System.Drawing.Point(120, 180);
            dtpFechaCompromiso.Size = new System.Drawing.Size(340, 23);
            dtpFechaCompromiso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Controls.Add(dtpFechaCompromiso);

            // Etiqueta Notas
            var lblNotas = new System.Windows.Forms.Label();
            lblNotas.Text = "Notas:";
            lblNotas.Location = new System.Drawing.Point(20, 220);
            lblNotas.AutoSize = true;
            this.Controls.Add(lblNotas);

            // Caja de texto Notas
            var txtNotas = new System.Windows.Forms.TextBox();
            txtNotas.Location = new System.Drawing.Point(120, 220);
            txtNotas.Size = new System.Drawing.Size(340, 80);
            txtNotas.Multiline = true;
            this.Controls.Add(txtNotas);

            // Botón Guardar
            var btnGuardar = new System.Windows.Forms.Button();
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new System.Drawing.Point(120, 320);
            btnGuardar.Size = new System.Drawing.Size(100, 30);
            btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.Controls.Add(btnGuardar);

            // Botón Cancelar
            var btnCancelar = new System.Windows.Forms.Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new System.Drawing.Point(260, 320);
            btnCancelar.Size = new System.Drawing.Size(100, 30);
            btnCancelar.BackColor = System.Drawing.Color.LightCoral;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.Controls.Add(btnCancelar);

            this.ResumeLayout(false);
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
