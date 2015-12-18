using Nancy;
using Nancy.ModelBinding;
using PrestamosAPI.Models;
using PrestamosAPI.Infraestructure;
using PrestamosAPI.DAO;

namespace PrestamosAPI.Modules
{
    public class DeudorModule : NancyModule
    {
        public DeudorModule(){

            Post["/deudor/crear"] = parameters => {
                Deudor deudor = this.Bind();

                var deudorDAO = new DeudorDAO();
                deudorDAO.Crear(deudor);

                return HttpStatusCode.OK;
            };
        }
    }
}
