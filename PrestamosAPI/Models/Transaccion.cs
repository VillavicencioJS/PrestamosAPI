using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrestamosAPI.Models
{
    public class Transaccion
    {
        public string Tipo { get; set; }

        public float Valor { get; set; }

        public int PrestamistaID { get; set; }

        public int DeudorID { get; set; }
    }
}
