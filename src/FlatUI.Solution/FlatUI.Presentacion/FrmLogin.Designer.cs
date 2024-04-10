namespace FlatUI.Presentacion
{
    partial class FrmLogin
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
            panelLateral = new Panel();
            pictureBox2 = new PictureBox();
            lbNombreSoftware = new Label();
            panel1 = new Panel();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            btnIniciarSesion = new Button();
            lbClave = new Label();
            txtClave = new TextBox();
            lbUsername = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(44, 58, 71);
            panelLateral.Controls.Add(pictureBox2);
            panelLateral.Controls.Add(lbNombreSoftware);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(226, 167);
            panelLateral.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.inventory;
            pictureBox2.Location = new Point(61, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbNombreSoftware
            // 
            lbNombreSoftware.AutoSize = true;
            lbNombreSoftware.BackColor = Color.FromArgb(44, 58, 71);
            lbNombreSoftware.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreSoftware.ForeColor = Color.White;
            lbNombreSoftware.Location = new Point(25, 126);
            lbNombreSoftware.Name = "lbNombreSoftware";
            lbNombreSoftware.Size = new Size(172, 19);
            lbNombreSoftware.TabIndex = 2;
            lbNombreSoftware.Text = "SISTEMA DE INVENTARIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnIniciarSesion);
            panel1.Controls.Add(lbClave);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(226, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 167);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(147, 137);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.c_sharp;
            pictureBox1.Location = new Point(253, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DodgerBlue;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(26, 137);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(102, 23);
            btnIniciarSesion.TabIndex = 9;
            btnIniciarSesion.Text = "Ingresar";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lbClave
            // 
            lbClave.AutoSize = true;
            lbClave.ForeColor = Color.Black;
            lbClave.Location = new Point(27, 90);
            lbClave.Name = "lbClave";
            lbClave.Size = new Size(70, 15);
            lbClave.TabIndex = 8;
            lbClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(27, 108);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(222, 23);
            txtClave.TabIndex = 7;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(27, 44);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(50, 15);
            lbUsername.TabIndex = 6;
            lbUsername.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(27, 62);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(222, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESION";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 167);
            Controls.Add(panel1);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbNombreSoftware;
        private Label label1;
        private Label lbUsername;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnIniciarSesion;
        private Label lbClave;
        private Button btnSalir;
        private PictureBox pictureBox2;
    }
}