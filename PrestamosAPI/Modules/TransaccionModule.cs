using Nancy;
using Nancy.ModelBinding;
using PrestamosAPI.Models;
using PrestamosAPI.DAO;
using System;
using System.Diagnostics;
using System.Dynamic;
using Nancy.ViewEngines.Razor;

namespace PrestamosAPI.Modules
{
    public class TransaccionModule: NancyModule
    {

        public TransaccionModule(){
            
            Get["/transaccion/traer/{idPrestamista}"] = parameters =>
            {
                var idPrestamista = int.Parse(parameters.idPrestamista.Value);
                var transaccionDAO = new TransaccionesDAO();
                var respuesta = transaccionDAO.TraerTotalDeudas(idPrestamista);

                return  Negotiate.WithStatusCode(HttpStatusCode.OK).WithModel(new Total { Valor = respuesta });   
            };

            Post["/transaccion/crear"] = parameters => {

                Transaccion transaccion = this.Bind();

                var transaccionDAO = new TransaccionesDAO();
                transaccionDAO.Crear(transaccion);

                return HttpStatusCode.OK;
            };

        }
    }
}
