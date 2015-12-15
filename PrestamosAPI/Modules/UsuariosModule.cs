using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using PrestamosAPI.Models;

namespace PrestamosAPI.Modules
{
    public class UsuariosModule : NancyModule
    {
        public UsuariosModule() {

            Post["/usuarios/crear"] = parameters =>
            {
                var usuario = new Usuario();
                

                return View["index"];
            };
        
        }
    }
}
