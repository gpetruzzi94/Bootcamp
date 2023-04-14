using CodigoComun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;
using CodigoComun.Datos;
//using CodigoComun.Modelo;

namespace CodigoComun.Negocio
{


    public class ArticuloServices
    {
        private ArticuloRepository articuloRepository =new ArticuloRepository();
        
        
        public string AgregarArticulo(Articulo articuloAAGregar) {
            
           
            int r = articuloRepository.AddArticulo(articuloAAGregar);

            if (r == 1) {

                return "Articulo agregado";
            }
            else
            {
                return "No se pudo agregar el articulo";

            }
        
        
        
        }

        public string ActualizarArticulo(Articulo articuloAActualizar)
        {

            
            int r = articuloRepository.UpdateArticulo(articuloAActualizar);

            if (r == 1)
            {

                return "Articulo modificado";
            }
            else
            {
                return "No se pudo modificar el articulo";

            }



        }

        public string BorrarArticulo(int itemId)
        {


            int r = articuloRepository.EliminarArticulo(itemId);

            if (r == 1)
            {

                return "Articulo eliminado";
            }
            else
            {
                return "No se pudo eliminar el articulo";

            }



        }

        public Articulo BuscarId(int itemId) { 
        

            Articulo articuloAuxiliar = new Articulo();
            articuloAuxiliar = articuloRepository.GetArticuloById(itemId);

            return articuloAuxiliar;

   
        
        }

        public List<Articulo> GetAllArticulos() {

            return articuloRepository.GetAllArticulos();
        

        
        }


    }
}
