using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;
using CodigoComun.DTO;

namespace CodigoComun.Datos
{
    public class ArticuloRepository
    {
        StocksAppContext db = new StocksAppContext();
        ArticuloDTO articuloDTO = new ArticuloDTO();
        public List<Articulo> GetAllArticulos() { 
        
            List<Articulo> articulos = new List<Articulo>();
            articulos = db.Articulos.ToList();

            return articulos;
        
        }

        public ArticuloDTO GetArticuloById(int id) { 
        
            articuloDTO = new ArticuloDTO();
            articuloDTO.articulo = db.Articulos.Find(id);
            return articuloDTO;

        
        }

        public int AddArticulo(Articulo articuloAAgregar) {

            db.Articulos.Add(articuloAAgregar);
            int resultado = db.SaveChanges();  
            return resultado;

        }


        public int EliminarArticulo(int id) {

            db.Articulos.Remove(db.Articulos.Find(id));
            int resultado = db.SaveChanges();

            return resultado;


        }


        public int UpdateArticulo(Articulo articuloAActualizar) {


            db.Entry(articuloAActualizar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            int resultado = db.SaveChanges();

            return resultado;
        
        
        }



    }



}


