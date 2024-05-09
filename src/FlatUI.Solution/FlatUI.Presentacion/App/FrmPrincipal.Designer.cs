namespace FlatUI.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLateral = new Panel();
            btnSalir = new Button();
            btnConfiguracion = new Button();
            btnReportes = new Button();
            btnBodega = new Button();
            btnInventario = new Button();
            btnProducto = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelLateralHeader = new Panel();
            panelHeader = new Panel();
            btnClose = new Button();
            panelContent = new Panel();
            btnUsuarios = new Button();
            panelLateral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(44, 58, 71);
            panelLateral.Controls.Add(btnUsuarios);
            panelLateral.Controls.Add(btnSalir);
            panelLateral.Controls.Add(btnConfiguracion);
            panelLateral.Controls.Add(btnReportes);
            panelLateral.Controls.Add(btnBodega);
            panelLateral.Controls.Add(btnInventario);
            panelLateral.Controls.Add(btnProducto);
            panelLateral.Controls.Add(btnDashboard);
            panelLateral.Controls.Add(panel1);
            panelLateral.Controls.Add(panelLateralHeader);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(186, 561);
            panelLateral.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(224, 224, 224);
            btnSalir.Image = Properties.Resources.logout2_16;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 529);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(5, 0, 0, 0);
            btnSalir.Size = new Size(186, 32);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "      Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.ForeColor = Color.FromArgb(224, 224, 224);
            btnConfiguracion.Image = Properties.Resources.settings_16;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(0, 292);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(5, 0, 0, 0);
            btnConfiguracion.Size = new Size(186, 32);
            btnConfiguracion.TabIndex = 7;
            btnConfiguracion.Text = "  Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.ForeColor = Color.FromArgb(224, 224, 224);
            btnReportes.Image = Properties.Resources.printing_16;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 260);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(5, 0, 0, 0);
            btnReportes.Size = new Size(186, 32);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "  Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnBodega
            // 
            btnBodega.Cursor = Cursors.Hand;
            btnBodega.Dock = DockStyle.Top;
            btnBodega.FlatAppearance.BorderSize = 0;
            btnBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnBodega.FlatStyle = FlatStyle.Flat;
            btnBodega.ForeColor = Color.FromArgb(224, 224, 224);
            btnBodega.Image = Properties.Resources.product2_16;
            btnBodega.ImageAlign = ContentAlignment.MiddleLeft;
            btnBodega.Location = new Point(0, 228);
            btnBodega.Name = "btnBodega";
            btnBodega.Padding = new Padding(5, 0, 0, 0);
            btnBodega.Size = new Size(186, 32);
            btnBodega.TabIndex = 5;
            btnBodega.Text = "  Bodega";
            btnBodega.TextAlign = ContentAlignment.MiddleLeft;
            btnBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBodega.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.ForeColor = Color.FromArgb(224, 224, 224);
            btnInventario.Image = Properties.Resources.pie_chart_16;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(0, 196);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(5, 0, 0, 0);
            btnInventario.Size = new Size(186, 32);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "       Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            btnProducto.Cursor = Cursors.Hand;
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = Color.FromArgb(224, 224, 224);
            btnProducto.Image = Properties.Resources.product_16;
            btnProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducto.Location = new Point(0, 164);
            btnProducto.Name = "btnProducto";
            btnProducto.Padding = new Padding(5, 0, 0, 0);
            btnProducto.Size = new Size(186, 32);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "       Producto";
            btnProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(224, 224, 224);
            btnDashboard.Image = Properties.Resources.dashboard_16;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 132);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(5, 0, 0, 0);
            btnDashboard.Size = new Size(186, 32);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "       Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.c_sharp;
            pictureBox1.Location = new Point(59, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLateralHeader
            // 
            panelLateralHeader.BackColor = Color.FromArgb(109, 33, 79);
            panelLateralHeader.Dock = DockStyle.Top;
            panelLateralHeader.Location = new Point(0, 0);
            panelLateralHeader.Name = "panelLateralHeader";
            panelLateralHeader.Size = new Size(186, 32);
            panelLateralHeader.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(179, 55, 113);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(186, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(998, 32);
            panelHeader.TabIndex = 1;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(962, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 32);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(186, 32);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(998, 529);
            panelContent.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(179, 55, 113);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = Color.FromArgb(224, 224, 224);
            btnUsuarios.Image = Properties.Resources.settings_16;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 324);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(5, 0, 0, 0);
            btnUsuarios.Size = new Size(186, 32);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "  Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            ControlBox = false;
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelLateral);
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelLateral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Panel panelLateralHeader;
        private Panel panelHeader;
        private Button btnDashboard;
        private Panel panel1;
        private Button btnConfiguracion;
        private Button btnReportes;
        private Button btnBodega;
        private Button btnInventario;
        private Button btnProducto;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private Button btnClose;
        private Panel panelContent;
        private Button btnUsuarios;
    }
}
