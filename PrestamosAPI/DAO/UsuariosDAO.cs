using PrestamosAPI.Infraestructure;
using PrestamosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrestamosAPI.DAO
{
    public class UsuariosDAO
    {

        private DBConnect db;

        public UsuariosDAO()
        {
            db = new DBConnect();
        }

        public void Crear(Usuario usuario){
            usuario.Clave = Hash.GetSHA1(usuario.Clave);
            var query = string.Format("INSERT INTO usuarios (USUARIO, CLAVE) VALUES('{0}', '{1}')", usuario.Nombre, usuario.Clave);
            db.Insert(query);
        }

        public int TraerRandom()
        {
            var query = "SELECT ID FROM usuarios ORDER BY RAND() LIMIT 1";
            return int.Parse(db.Count(query).ToString());
        }


    }
}
