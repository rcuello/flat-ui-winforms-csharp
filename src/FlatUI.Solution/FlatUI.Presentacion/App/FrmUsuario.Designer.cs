namespace FlatUI.Presentacion.App
{
    partial class FrmUsuario
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
            panel1 = new Panel();
            btnGuardar = new Button();
            txtPassword2 = new TextBox();
            label5 = new Label();
            txtPassword1 = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtNombreCompleto = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            label6 = new Label();
            dgUsuarios = new DataGridView();
            IdUsuario = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPassword2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 613);
            panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(14, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(177, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(14, 298);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '*';
            txtPassword2.Size = new Size(177, 23);
            txtPassword2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 269);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 8;
            label5.Text = "Confirma Contraseña:";
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(14, 230);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.PasswordChar = '*';
            txtPassword1.Size = new Size(177, 23);
            txtPassword1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 209);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(12, 171);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(177, 23);
            txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(12, 115);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(177, 23);
            txtNombreCompleto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Completo:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 63);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 23);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Usuario:";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(228, 27);
            label6.Name = "label6";
            label6.Size = new Size(713, 59);
            label6.TabIndex = 1;
            label6.Text = "Lista de Usuarios";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Usuario, NombreCompleto, Correo });
            dgUsuarios.Dock = DockStyle.Bottom;
            dgUsuarios.Location = new Point(211, 115);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.Size = new Size(765, 498);
            dgUsuarios.TabIndex = 2;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 613);
            Controls.Add(dgUsuarios);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPassword2;
        private Label label5;
        private TextBox txtPassword1;
        private Label label4;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtNombreCompleto;
        private Label label2;
        private TextBox txtUsername;
        private Button btnGuardar;
        private Label label6;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
    }
}