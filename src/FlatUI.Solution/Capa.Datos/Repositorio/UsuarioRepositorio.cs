using System.Configuration;
using Capa.Entidad;
using Microsoft.Data.SqlClient;

namespace Capa.Datos.Repositorio
{
    public class UsuarioRepositorio
    {

        public List<Usuario> GetUsuarios()
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
            var lista = new List<Usuario>();

            using (var conexion = new SqlConnection(cadenaConexion))
            {
                //Conectar a la base de datos
                conexion.Open();

                string sql = "SELECT IdUsuario,Usuario,NombreCompleto,Correo,Estado,FechaRegistro FROM Usuarios";

                SqlCommand comando = new SqlCommand(sql, conexion);


                //Ejecutar comando en la base de datos
                using (var cursor = comando.ExecuteReader())
                {
                    //Recorrer resultado
                    while (cursor.Read())
                    {
                        var usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(cursor["IdUsuario"]);
                        usuario.NombreUsuario = Convert.ToString(cursor["Usuario"]);
                        usuario.NombreCompleto = Convert.ToString(cursor["NombreCompleto"]);
                        usuario.Correo = Convert.ToString(cursor["Correo"]);
                        usuario.Estado = Convert.ToBoolean(cursor["Estado"]);
                        usuario.FechaRegistro = Convert.ToDateTime(cursor["FechaRegistro"]);

                        lista.Add(usuario);
                    }
                }
            }

            return lista;
        }
        public void GuardarUsuario(Usuario usuario)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();

            using(var conexion = new SqlConnection(cadenaConexion)) 
            {
                conexion.Open();

                var sql = "INSERT INTO [Usuarios]([Usuario],[NombreCompleto],[Correo],[Clave],[Estado],[FechaRegistro]) VALUES (@username,@nombreCompleto,@correo ,@clave,@estado,@fechaRegistro)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@username", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                comando.Parameters.AddWithValue("@correo", usuario.Correo);
                comando.Parameters.AddWithValue("@clave", usuario.Clave);
                comando.Parameters.AddWithValue("@estado", true);
                comando.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);

                comando.ExecuteNonQuery();
            }
        }

        public Usuario Autenticar(string nombreUsuario,string clave)
        {
            var cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();

            using(var conexion = new SqlConnection(cadenaConexion)) 
            {
                //Conectar a la base de datos
                conexion.Open();

                string sql = "SELECT IdUsuario,Usuario,NombreCompleto,Correo,Estado,FechaRegistro FROM Usuarios WHERE Usuario = @nombreUsuario and clave=@claveUsuario";

                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@claveUsuario", clave);

                //Ejecutar comando en la base de datos
                using(var cursor = comando.ExecuteReader()) 
                {
                    //Recorrer resultado
                    while(cursor.Read()) 
                    {
                        var usuario = new Usuario();
                        usuario.IdUsuario = Convert.ToInt32(cursor["IdUsuario"]);
                        usuario.NombreUsuario = Convert.ToString(cursor["Usuario"]);
                        usuario.NombreCompleto = Convert.ToString(cursor["NombreCompleto"]);
                        usuario.Correo = Convert.ToString(cursor["Correo"]);
                        usuario.Estado = Convert.ToBoolean(cursor["Estado"]);
                        usuario.FechaRegistro = Convert.ToDateTime(cursor["FechaRegistro"]);

                        return usuario;
                    }
                }

            }

            return null;
        }
    }
}
