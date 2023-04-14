using CodigoComun.Datos;
using CodigoComun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Negocio
{
    public class StockService
    {

        private StockRepository StockRepository = new StockRepository();


        public string AgregarStock(Stock StockAAGregar)
        {

            StockRepository = new StockRepository();
            int r = StockRepository.AddStockDb(StockAAGregar);

            if (r == 1)
            {

                return "Stock agregado";
            }
            else
            {
                return "No se pudo agregar el Stock";

            }



        }

        public string ActualizarStock(Stock StockAActualizar)
        {

            StockRepository = new StockRepository();
            int r = StockRepository.UpdateStock(StockAActualizar);

            if (r == 1)
            {

                return "Stock modificado";
            }
            else
            {
                return "No se pudo modificar el Stock";

            }



        }

        public string BorrarStock(int itemId)
        {


            int r = StockRepository.EliminarStockDb(itemId);

            if (r == 1)
            {

                return "Stock eliminado";
            }
            else
            {
                return "No se pudo eliminar el Stock";

            }



        }

        public Stock BuscarId(int itemId)
        {


            Stock StockAuxiliar = new Stock();
            StockAuxiliar = StockRepository.GetStockById(itemId);

            return StockAuxiliar;



        }

        public List<Stock> GetAllStocks()
        {

            return StockRepository.GetAllStocks();



        }



    }
}
