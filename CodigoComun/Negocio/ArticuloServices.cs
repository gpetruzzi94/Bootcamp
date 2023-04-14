using CodigoComun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Modelo;

namespace CodigoComun.Negocio
{
    public class ArticuloServices
    {
        private ArticuloRepository articuloRepository =new ArticuloRepository();
        public int AgregarArticulo(Articulo articuloAAGregar) {

           
            int r = articuloRepository.AddArticuloDb(articuloAAGregar);

            if (r == 1) {

                return 1;
            }
            else
            {
                return -1;

            }
        
        
        
        }

        public int ActualizarArticulo(Articulo articuloAActualizar)
        {

            
            int r = articuloRepository.AlterArticuloDb(articuloAActualizar);

            if (r == 1)
            {

                return 1;
            }
            else
            {
                return -1;

            }



        }

        public int BorrarArticulo(int itemId)
        {


            int r = articuloRepository.DeleteArticuloDb(itemId);

            if (r == 1)
            {

                return 1;
            }
            else
            {
                return -1;

            }



        }

        public Articulo BuscarId(int itemId) { 
        

            Articulo articuloAuxiliar = new Articulo();
            articuloAuxiliar = articuloRepository.GetItemPorIdDb(itemId);

            return articuloAuxiliar;

   
        
        }

        public List<Articulo> GetItems() {

            return articuloRepository.GetAllItemsDb();
        

        
        }


    }
}
