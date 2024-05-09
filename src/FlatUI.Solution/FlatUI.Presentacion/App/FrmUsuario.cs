using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.Datos.Repositorio;
using Capa.Entidad;

namespace FlatUI.Presentacion.App
{
    public partial class FrmUsuario : Form
    {
        private UsuarioRepositorio m_usuarioRepositorio;
        public FrmUsuario()
        {
            InitializeComponent();
            this.m_usuarioRepositorio = new UsuarioRepositorio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var username = this.txtUsername.Text;
            var nombreCompleto = this.txtNombreCompleto.Text;
            var correo = this.txtCorreo.Text;
            var pwd1 = this.txtPassword1.Text;
            var pwd2=this.txtPassword2.Text;

            //TODO: Pendiente realizar validaciones

            var nuevoUsuario = new Usuario 
            {
                NombreUsuario = username,
                Correo = correo,
                NombreCompleto=nombreCompleto,
                Clave=pwd1,
                Estado=true

            };

            try
            {
                this.m_usuarioRepositorio.GuardarUsuario(nuevoUsuario);

                MessageBox.Show("Usuario almacenado exitosamente!", "Guardar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCorreo.Clear();
                txtNombreCompleto.Clear();
                txtPassword1.Clear();
                txtPassword2.Clear();
                txtUsername.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ha ocurrido un error. Error: {ex.Message}", "Guardar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
