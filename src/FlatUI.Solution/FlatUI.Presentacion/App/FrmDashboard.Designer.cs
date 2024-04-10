namespace FlatUI.Presentacion.App
{
    partial class FrmDashboard
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
            panelContent = new Panel();
            lbTitulo = new Label();
            panelProduct = new Panel();
            panelInventario = new Panel();
            panelBodega = new Panel();
            lbProducto = new Label();
            lbTotalProducto = new Label();
            lbInventario = new Label();
            label1 = new Label();
            lbTotalInventario = new Label();
            lbTotalBodega = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panelContent.SuspendLayout();
            panelProduct.SuspendLayout();
            panelInventario.SuspendLayout();
            panelBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.Controls.Add(pictureBox1);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(panelBodega);
            panelContent.Controls.Add(panelInventario);
            panelContent.Controls.Add(panelProduct);
            panelContent.Controls.Add(lbTitulo);
            panelContent.Location = new Point(28, 16);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(698, 398);
            panelContent.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(5, 8);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(113, 22);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Dashboard";
            // 
            // panelProduct
            // 
            panelProduct.BackColor = Color.FromArgb(255, 165, 2);
            panelProduct.Controls.Add(lbTotalProducto);
            panelProduct.Controls.Add(lbProducto);
            panelProduct.Location = new Point(6, 44);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(216, 79);
            panelProduct.TabIndex = 1;
            // 
            // panelInventario
            // 
            panelInventario.BackColor = Color.FromArgb(27, 156, 252);
            panelInventario.Controls.Add(lbTotalInventario);
            panelInventario.Controls.Add(lbInventario);
            panelInventario.Location = new Point(236, 44);
            panelInventario.Name = "panelInventario";
            panelInventario.Size = new Size(216, 79);
            panelInventario.TabIndex = 2;
            // 
            // panelBodega
            // 
            panelBodega.BackColor = Color.FromArgb(88, 177, 159);
            panelBodega.Controls.Add(lbTotalBodega);
            panelBodega.Controls.Add(label1);
            panelBodega.Location = new Point(468, 44);
            panelBodega.Name = "panelBodega";
            panelBodega.Size = new Size(216, 79);
            panelBodega.TabIndex = 3;
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProducto.ForeColor = Color.White;
            lbProducto.Location = new Point(2, 9);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(68, 15);
            lbProducto.TabIndex = 0;
            lbProducto.Text = "PRODUCTO";
            // 
            // lbTotalProducto
            // 
            lbTotalProducto.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalProducto.ForeColor = Color.White;
            lbTotalProducto.Location = new Point(76, 21);
            lbTotalProducto.Name = "lbTotalProducto";
            lbTotalProducto.Size = new Size(137, 38);
            lbTotalProducto.TabIndex = 1;
            lbTotalProducto.Text = "48,320";
            lbTotalProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbInventario
            // 
            lbInventario.AutoSize = true;
            lbInventario.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInventario.ForeColor = Color.White;
            lbInventario.Location = new Point(3, 9);
            lbInventario.Name = "lbInventario";
            lbInventario.Size = new Size(74, 15);
            lbInventario.TabIndex = 1;
            lbInventario.Text = "INVENTARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "BODEGA";
            // 
            // lbTotalInventario
            // 
            lbTotalInventario.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalInventario.ForeColor = Color.White;
            lbTotalInventario.Location = new Point(76, 24);
            lbTotalInventario.Name = "lbTotalInventario";
            lbTotalInventario.Size = new Size(137, 38);
            lbTotalInventario.TabIndex = 2;
            lbTotalInventario.Text = "1,320,510";
            lbTotalInventario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbTotalBodega
            // 
            lbTotalBodega.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalBodega.ForeColor = Color.White;
            lbTotalBodega.Location = new Point(76, 24);
            lbTotalBodega.Name = "lbTotalBodega";
            lbTotalBodega.Size = new Size(137, 38);
            lbTotalBodega.TabIndex = 3;
            lbTotalBodega.Text = "110,356";
            lbTotalBodega.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 142);
            label2.Name = "label2";
            label2.Size = new Size(199, 22);
            label2.TabIndex = 4;
            label2.Text = "Grafico de ejemplo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sample_chart;
            pictureBox1.Location = new Point(14, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 531);
            Controls.Add(panelContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            WindowState = FormWindowState.Maximized;
            Resize += FrmDashboard_Resize;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            panelInventario.ResumeLayout(false);
            panelInventario.PerformLayout();
            panelBodega.ResumeLayout(false);
            panelBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContent;
        private Label lbTitulo;
        private Panel panelProduct;
        private Panel panelBodega;
        private Panel panelInventario;
        private Label lbProducto;
        private Label lbTotalProducto;
        private Label label1;
        private Label lbInventario;
        private Label lbTotalBodega;
        private Label lbTotalInventario;
        private PictureBox pictureBox1;
        private Label label2;
    }
}