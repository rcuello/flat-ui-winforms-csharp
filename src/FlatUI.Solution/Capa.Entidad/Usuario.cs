
namespace Capa.Entidad
{
    public class Usuario
    {
		public int IdUsuario { get; set; }
		public string NombreUsuario { get; set; }
		public string NombreCompleto { get; set; }
		public string Correo { get; set; }
		public string Clave { get; set; }
		public bool Estado { get; set; }
		public DateTime FechaRegistro { get; set; }
    }
}
