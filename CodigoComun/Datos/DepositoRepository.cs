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
        StocksAppContext db = new StocksAppContext();


            
        public List<Deposito> GetAllDepositos() { 
        

            List<Deposito> depositos = new List<Deposito>();
            depositos = db.Depositos.ToList();

            return depositos;

  
        }


        public Deposito GetDepositoById(int id)
        {


            Deposito deposito = new Deposito();
            deposito = db.Depositos.Find(id);

            return deposito;

        }

        public int AddDepositoDb(Deposito depositoAAgregar) { 
        

            db.Depositos.Add(depositoAAgregar);
            int resultado = db.SaveChanges();


            return resultado;
        
        }

        public int EliminarDepositoDb(int id)
        {


            db.Depositos.Remove(db.Depositos.Find(id));

            int resultado = db.SaveChanges();


            return resultado;

        }

        public int UpdateDeposito(Deposito depositoAActualizar ) {


            db.Entry(depositoAActualizar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            
            int resultado = db.SaveChanges();


            return resultado;



        }

    }
}
