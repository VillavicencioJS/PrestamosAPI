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

            Get["/usuarios/traerRandom/"] = parameters =>
            {
                UsuariosDAO usuarioDAO = new UsuariosDAO();
                var idRandom = usuarioDAO.TraerRandom();

                return Negotiate.WithStatusCode(HttpStatusCode.OK).WithModel(new UsuarioRandom{ Id = idRandom }); 
            };

        }
    }
}
