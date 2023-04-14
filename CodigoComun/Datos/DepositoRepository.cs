using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;

namespace CodigoComun.Datos
{
    public class DepositoRepository
    {

        public List<Deposito> GetAllDepositos() { 
        
            StocksAppContext db = new StocksAppContext();

            List<Deposito> depositos = new List<Deposito>();
            depositos = db.Depositos.ToList();

            return depositos;

  
        }


        public Deposito GetDepositoById(int id)
        {

            StocksAppContext db = new StocksAppContext();

            Deposito deposito = new Deposito();
            deposito = db.Depositos.Find(id);

            return deposito;

        }

        public int AddDepositoDb(Deposito depositoAAgregar) { 
        
            StocksAppContext db = new StocksAppContext();

            db.Depositos.Add(depositoAAgregar);
            int resultado = db.SaveChanges();


            return resultado;
        
        }

        public int EliminarDepositoDb(int id)
        {

            StocksAppContext db =new StocksAppContext();
            db.Depositos.Remove(db.Depositos.Find(id));

            int resultado = db.SaveChanges();


            return resultado;

        }


    }
}
