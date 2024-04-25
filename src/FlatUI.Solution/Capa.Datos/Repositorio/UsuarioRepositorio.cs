using Capa.Entidad;
using Microsoft.Data.SqlClient;

namespace Capa.Datos.Repositorio
{
    public class UsuarioRepositorio
    {
        public Usuario Autenticar(string nombreUsuario,string clave)
        {
            using(var conexion = new SqlConnection("")) 
            {
                
            }

            return null;
        }
    }
}
