using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrestamosAPI.Infraestructure;
using PrestamosAPI.Models;

namespace PrestamosAPI.DAO
{
    public class TransaccionesDAO
    {
        private DBConnect db;

        public TransaccionesDAO() {
            db = new DBConnect();
        }

        public void Crear(Transaccion transaccion)
        {
            var query = string.Format("INSERT INTO transacciones (TIPO, VALOR, PRESTAMISTA_ID, DEUDOR_ID) VALUES('{0}', {1}, {2}, {3})", 
                transaccion.Tipo, 
                transaccion.Valor, 
                transaccion.PrestamistaID, 
                transaccion.DeudorID
            );

            db.Insert(query);
        }


        public float TraerTotalDeudas(int idPrestamista) {

            var query = "SELECT SUM(VALOR) FROM transacciones WHERE PRESTAMISTA_ID = " + idPrestamista;
            return db.Count(query);
        }
    }
}
