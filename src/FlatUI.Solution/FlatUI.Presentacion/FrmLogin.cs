namespace FlatUI.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();

            frmPrincipal.FormClosing += FrmPrincipal_FormClosing;
        }

        private void FrmPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            this.Show();
        }
    }
}
