using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PrestamosAPI.Infraestructure;
using PrestamosAPI.Models;

namespace PrestamosAPI.DAO
{
    public class DeudorDAO
    {
        private DBConnect db;

        public DeudorDAO(){
            db = new DBConnect();
        }


        public void Crear(Deudor deudor) {
            var query = string.Format("INSERT INTO persona (NOMBRE) VALUES('{0}')", deudor.Nombre);
            db.Insert(query);
        }
    }
}
