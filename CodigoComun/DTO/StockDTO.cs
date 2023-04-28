using AutoMapper;
using CodigoComun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.DTO
{
    public class StockDTO:BaseDTO
    {
        //public Stock stock { set; get; }

        public int Id { get; set; }
        public int? IdArticulo { get; set; }
        public int? IdDeposito { get; set; }
        public decimal? Cantidad { get; set; }

        public virtual Articulo IdArticuloNavigation { get; set; }
        public virtual Deposito IdDepositoNavigation { get; set; }



        public Stock GetStock(StockDTO stockDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<StockDTO, Stock>());
            var mapper = new Mapper(config);

            Stock stockADevolver = mapper.Map<Stock>(stockDTO);

            return stockADevolver;
        }

        public StockDTO GetStockDTO(Stock stock)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Stock, StockDTO>());
            var mapper = new Mapper(config);

            StockDTO stockADevolver = mapper.Map<StockDTO>(stock);

            return stockADevolver;
        }


        public string MostrarError()
        {

            return this.Mensaje;
        }

    }
}
