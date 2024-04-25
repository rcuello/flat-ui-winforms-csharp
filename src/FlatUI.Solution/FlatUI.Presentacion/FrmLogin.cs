using Capa.Datos.Repositorio;
using Capa.Entidad;

namespace FlatUI.Presentacion
{
    public partial class FrmLogin : Form
    {
        private UsuarioRepositorio usuarioRepositorio;

        public FrmLogin()
        {
            InitializeComponent();
            this.usuarioRepositorio = new UsuarioRepositorio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string claveUsuario = txtClave.Text;

            Usuario usuario = usuarioRepositorio.Autenticar(nombreUsuario, claveUsuario);

            if (usuario != null)
            {
                var frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();
                frmPrincipal.FormClosing += FrmPrincipal_FormClosing;
            }
            else
            {
                MessageBox.Show("Credenciales invalidas","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            

            
        }

        private void FrmPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            this.Show();
        }
    }
}
