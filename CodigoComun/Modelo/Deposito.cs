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

        AccesoDatos ac;

        public Deposito() { 
        
            ac = new AccesoDatos();
        }




        public int ActualizarEnDb(Deposito depositoAActualizar)
        {

            string capacidadAuxiliar = Convert.ToString(depositoAActualizar.Capacidad);
            capacidadAuxiliar = capacidadAuxiliar.Replace(",", ".");

            string query = $"update Depositos set Capacidad = '{capacidadAuxiliar}', " +
                $"Nombre = '{depositoAActualizar.Nombre}'," +
                $"Direccion = '{depositoAActualizar.Direccion}'" +
                $"where id = {depositoAActualizar.Id}";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = ac.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                ac.DesConectar();
            }
        }









    }
}
