using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Datos;

namespace CodigoComun.Modelo
{
    public class Articulo
    {
        //defino mis atributos 
        public int Id { get; set; }
        public string Nombre { set; get; }

        public string Marca { get; set; }

        public decimal MinimoStock { get; set; }
        public string Proveedor { get; set; }

        public float Precio { get; set; }

        public string Codigo { get; set; }



        /*
        private AccesoDatos ac;


        public Articulo()
        {
            ac = new AccesoDatos();

        }

        */

        //Metodos 

        /*

        public int EliminarEnDb(int idArticuloAEliminar)
        {
            string query = $"delete Articulos where id={idArticuloAEliminar}";
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




        public int AgregarEnDb()
        {
            string query = $"insert into Articulos (Nombre, Marca,MinimoStock,Proveedor,Precio)";
            query += $"values('{this.Nombre}', '{this.Marca}', '{this.MinimoStock}', '{this.Proveedor}', " +
                $" '{this.Precio}')";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = ac.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                //Log.Escribir(0, "ERROR", "Ocurrio un error en ChangeAddPartidaToProduct actualizando que guarde partida a producto " + ex.Message);
                return -1;
            }
            finally
            {
                ac.DesConectar();
            }


        }


        public int ActualizarEnDb(Articulo articuloAActualizar)
        {


            
            string auxiliarMinimoStock = Convert.ToString(articuloAActualizar.MinimoStock);
            auxiliarMinimoStock = auxiliarMinimoStock.Replace(",", ".");
            string auxiliarPrecio = Convert.ToString(articuloAActualizar.Precio);
            auxiliarPrecio = auxiliarPrecio.Replace(",", ".");

            string query = $"update Articulos set Nombre = '{articuloAActualizar.Nombre}', " +
                $"Marca = '{articuloAActualizar.Marca}'," +
                $"MinimoStock = '{auxiliarMinimoStock}'," +
                $"Proveedor = '{articuloAActualizar.Proveedor}'," +
                $"Precio = '{auxiliarPrecio}'" +
                $"where id = {articuloAActualizar.Id}";
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




        public Articulo GetItemsPorId(int itemId)
        {
            try
            {
                string select = $"select * from Articulos where id={itemId}";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = ac.execDT(command);


                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                Articulo item1 = new Articulo();
                foreach (DataRow dr in dt.Rows)
                {
                    item1.Id = Convert.ToInt32(dr["Id"]);
                    item1.Nombre = dr["Nombre"].ToString();
                    item1.Marca = dr["Marca"].ToString();
                    item1.MinimoStock = Convert.ToDecimal(dr["MinimoStock"]);
                    item1.Proveedor = dr["Proveedor"].ToString();
                    item1.Precio = (float)Convert.ToDecimal(dr["Precio"]);
                }
                return item1;


            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                ac.DesConectar();
            }
        }



        public List<Articulo> GetTodosLosArticulos()
        {
            try
            {
                string select = $"select * from Articulos ";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = ac.execDT(command);

                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                List<Articulo> articulosADevovlerConDatosDelaBaseDeDatos = new List<Articulo>();
                foreach (DataRow dr in dt.Rows)
                {
                    Articulo articuloAuxiliar = new Articulo();
                    articuloAuxiliar.Id = Convert.ToInt32(dr["Id"]);
                    articuloAuxiliar.Nombre = dr["Nombre"].ToString();
                    articuloAuxiliar.Marca = dr["Marca"].ToString();
                    articuloAuxiliar.MinimoStock = Convert.ToDecimal(dr["MinimoStock"]);
                    articuloAuxiliar.Proveedor = dr["Proveedor"].ToString();
                    articuloAuxiliar.Precio = (float)Convert.ToDecimal(dr["Precio"]);
                    //agrego a la lista
                    articulosADevovlerConDatosDelaBaseDeDatos.Add(articuloAuxiliar);
                }

                return articulosADevovlerConDatosDelaBaseDeDatos;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                ac.DesConectar();
            }
        }


        */

    }
}
