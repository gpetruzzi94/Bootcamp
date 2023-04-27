using CodigoComun.Datos;
using CodigoComun.Entities;
using CodigoComun.DTO;
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


        public StockDTO AgregarStock(StockDTO StockAAGregar)
        {

            StockRepository = new StockRepository();
            int r = StockRepository.AddStockDb(StockAAGregar.stock);

            if (r == 1)
            {
                StockAAGregar.Mensaje = "Stock agregado";
                return StockAAGregar;
            }
            else
            {
                StockAAGregar.HuboError = true;
                StockAAGregar.Mensaje = "No se pudo agregar el Stock";
                return StockAAGregar;

            }



        }

        public StockDTO ActualizarStock(StockDTO StockAActualizar)
        {

            StockRepository = new StockRepository();
            int r = StockRepository.UpdateStock(StockAActualizar.stock);

            if (r == 1)
            {
                StockAActualizar.Mensaje = "Stock modificado";
                return StockAActualizar;
            }
            else
            {
                StockAActualizar.HuboError = true;
                StockAActualizar.Mensaje = "No se pudo modificar el Stock";
                return StockAActualizar;

            }



        }

        public StockDTO BorrarStock(int itemId)
        {


            int r = StockRepository.EliminarStockDb(itemId);
            StockDTO stockDTO = new StockDTO();

            if (r == 1)
            {
                stockDTO.Mensaje = "Stock eliminado";
                return stockDTO;
            }
            else
            {
                stockDTO.HuboError = true;
                stockDTO.Mensaje = "No se pudo eliminar el Stock";
                return stockDTO;

            }



        }

        public StockDTO BuscarId(int itemId)
        {


            StockDTO StockAuxiliar = new StockDTO();
            StockAuxiliar = StockRepository.GetStockById(itemId);

            return StockAuxiliar;



        }

        public List<Stock> GetAllStocks()
        {

            return StockRepository.GetAllStocks();



        }



    }
}
