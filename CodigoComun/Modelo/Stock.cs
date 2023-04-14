
using CodigoComun.Datos;
using CodigoComun.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Modelo
{
    public  class Stock
    {
        public int Id { get; set; }
        public Articulo ArticuloGuardado { get; set; }

        public Deposito DepositoDondeEstaGuardado { get; set; }

        public int IdArticulo { get { return ArticuloGuardado.Id; } }

        public int IdDeposito { get { return DepositoDondeEstaGuardado.Id; } }

        public decimal Cantidad { get; set; }


        AccesoDatos ac;

        public Stock()
        {
            this.ArticuloGuardado = new Articulo();
            this.DepositoDondeEstaGuardado = new Deposito();
            ac = new AccesoDatos();
        }



        public Stock GetItemsPorId(int itemId)
        {
            try
            {
                string select = $"select * from Stocks where id={itemId}";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = ac.execDT(command);


                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                Stock item1 = new Stock();
                foreach (DataRow dr in dt.Rows)
                {
                    item1.Id = Convert.ToInt32(dr["Id"]);
                    item1.ArticuloGuardado.Id = Convert.ToInt32(dr["IdArticulo"]);
                    item1.DepositoDondeEstaGuardado.Id = Convert.ToInt32(dr["IdDeposito"]);
                    item1.Cantidad = Convert.ToDecimal(dr["Cantidad"]);

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

        public List<Stock> GetTodosLosStocks()
        {
            try
            {
                string select = $"select * from Stocks ";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = ac.execDT(command);

                if (dt.Rows.Count <= 0)
                {
                    //no se encuentra pedido para actualizar estado
                    return null;
                }

                List<Stock> stocksADevolerConDatosDelaBaseDeDatos = new List<Stock>();
                foreach (DataRow dr in dt.Rows)
                {
                    Stock stockAuxiliar = new Stock();
                    stockAuxiliar.Id = Convert.ToInt32(dr["Id"]);
                    stockAuxiliar.ArticuloGuardado.Id = Convert.ToInt32(dr["IdArticulo"]);
                    stockAuxiliar.DepositoDondeEstaGuardado.Id = Convert.ToInt32(dr["IdDeposito"]);
                    stockAuxiliar.Cantidad = Convert.ToDecimal(dr["Cantidad"]);

                    Deposito depositoAuxiliar = new Deposito();
                    //Articulo articuloAuxiliar = new Articulo();
                    ArticuloServices articuloAuxiliar = new ArticuloServices();

                    stockAuxiliar.ArticuloGuardado = articuloAuxiliar.BuscarId(stockAuxiliar.ArticuloGuardado.Id);
                    //stockAuxiliar.DepositoDondeEstaGuardado = depositoAuxiliar.GetItemsPorId(stockAuxiliar.DepositoDondeEstaGuardado.Id);

                    //agrego a la lista
                    stocksADevolerConDatosDelaBaseDeDatos.Add(stockAuxiliar);
                }

                return stocksADevolerConDatosDelaBaseDeDatos;
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





        public int EliminarEnDb(int idStockAEliminar)
        {
            string query = $"delete Stocks where id={idStockAEliminar}";
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
            string query = $"insert into Stocks (IdArticulo,IdDeposito,Cantidad)";
            query += $"values('{this.ArticuloGuardado.Id}', '{this.DepositoDondeEstaGuardado.Id}', '{this.Cantidad}')";
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


        public int ActualizarEnDb(Stock stocksAActualizar)
        {
            string query = $"update Stocks set IdArticulo = '{stocksAActualizar.ArticuloGuardado.Id}', " +
                $"IdDeposito = '{stocksAActualizar.DepositoDondeEstaGuardado.Id}'," +
                $"Cantidad = '{stocksAActualizar.Cantidad}'" +
                $"where id = {stocksAActualizar.Id}";
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
