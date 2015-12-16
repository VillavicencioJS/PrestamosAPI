using Nancy;
using PrestamosAPI.DAO;
using PrestamosAPI.Models;

namespace PrestamosAPI.Modules
{
    public class UsuariosModule : NancyModule
    {
        public UsuariosModule() {
            
            Post["/usuarios/crear"] = parameters =>
            {
                var usuario = new Usuario { 
                    Nombre = "ivan",
                    Clave = "1234"
                };

                var usuarioDAO = new UsuariosDAO();
                usuarioDAO.Crear(usuario);


                return HttpStatusCode.OK;
            };
        }
    }
}
