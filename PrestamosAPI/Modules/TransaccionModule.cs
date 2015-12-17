using Nancy;
using Nancy.ModelBinding;
using PrestamosAPI.Models;
using PrestamosAPI.DAO;

namespace PrestamosAPI.Modules
{
    public class TransaccionModule: NancyModule
    {

        public TransaccionModule(){
            Post["/transaccion/crear"] = parameters => {

                Transaccion transaccion = this.Bind();

                var transaccionDAO = new TransaccionesDAO();
                transaccionDAO.Crear(transaccion);

                return HttpStatusCode.OK;
            };          
        }
    }
}
