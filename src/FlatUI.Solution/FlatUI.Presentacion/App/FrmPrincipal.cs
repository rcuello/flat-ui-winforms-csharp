using FlatUI.Presentacion.App;

namespace FlatUI.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private bool draggable;
        private int mouseX;
        private int mouseY;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                draggable = true;
                mouseX = Cursor.Position.X - this.Left;
                mouseY = Cursor.Position.Y - this.Top;
            }
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var frmDashboard = new FrmDashboard();
            frmDashboard.TopLevel = false;
            panelContent.Controls.Add(frmDashboard);
            frmDashboard.BringToFront();
            frmDashboard.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
