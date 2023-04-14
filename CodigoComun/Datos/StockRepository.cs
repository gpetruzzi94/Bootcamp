﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;

namespace CodigoComun.Datos
{
    public class StockRepository
    {
        StocksAppContext db = new StocksAppContext();


        public List<Stock> GetAllStocks()
        {


            List<Stock> Stocks = new List<Stock>();
            Stocks = db.Stocks.ToList();

            return Stocks;


        }


        public Stock GetStockById(int id)
        {


            Stock Stock = new Stock();
            Stock = db.Stocks.Find(id);

            return Stock;

        }

        public int AddStockDb(Stock StockAAgregar)
        {


            db.Stocks.Add(StockAAgregar);
            int resultado = db.SaveChanges();


            return resultado;

        }

        public int EliminarStockDb(int id)
        {


            db.Stocks.Remove(db.Stocks.Find(id));

            int resultado = db.SaveChanges();


            return resultado;

        }

        public int UpdateStock(Stock StockAActualizar)
        {


            db.Entry(StockAActualizar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            int resultado = db.SaveChanges();


            return resultado;



        }


    }
}
