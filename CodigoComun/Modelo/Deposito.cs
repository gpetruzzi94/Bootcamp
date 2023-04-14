using CodigoComun.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Modelo
{
    public class Deposito
    {
        public int Id { get; set; }
        public decimal Capacidad { get; set; }

        public string Nombre { get; set; }
        public string Direccion { get; set; }


    }
}
