using Nancy;
using PrestamosAPI.DAO;
using PrestamosAPI.Models;
using Nancy.ModelBinding;

namespace PrestamosAPI.Modules
{
    public class UsuariosModule : NancyModule
    {
        public UsuariosModule() {
            
            Post["/usuarios/crear"] = parameters =>
            {
                Usuario usuario = this.Bind();

                var usuarioDAO = new UsuariosDAO();
                usuarioDAO.Crear(usuario);

                return HttpStatusCode.OK;
            };



        }
    }
}
