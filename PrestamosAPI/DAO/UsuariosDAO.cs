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

    }
}
