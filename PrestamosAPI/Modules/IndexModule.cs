using Nancy;
using PrestamosAPI.Infraestructure;

namespace PrestamosAPI.Modules
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                var x = new DBConnect();
                x.OpenConnection();

                return View["index"];
            };
        }
    }
}