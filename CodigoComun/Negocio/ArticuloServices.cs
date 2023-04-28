using CodigoComun.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoComun.Entities;
using CodigoComun.Datos;
using CodigoComun.DTO;

namespace CodigoComun.Negocio
{

    public class ArticuloServices
    {
        private ArticuloRepository articuloRepository =new ArticuloRepository();
        
        
        public ArticuloDTO AgregarArticulo(ArticuloDTO articuloAAGregar) {
            try
            {
                Articulo articulo = articuloAAGregar.GetArticulo(articuloAAGregar);
                int r = articuloRepository.AddArticulo(articulo);

                if (r == 1)
                {
                    articuloAAGregar.Mensaje = "Articulo agregado";
                    return articuloAAGregar;
                }
                else
                {
                    articuloAAGregar.HuboError = true;
                    articuloAAGregar.Mensaje = "No se pudo agregar el articulo";
                    return articuloAAGregar;

                }

            }
            catch (Exception ex) { 
                articuloAAGregar.HuboError=true;
                articuloAAGregar.Mensaje = $"Hubo una excepcion dando de alta al articulo {ex.Message }";
                return articuloAAGregar;
            
            }
        
        
        }

        public ArticuloDTO ActualizarArticulo(ArticuloDTO articuloAActualizar)
        {

            Articulo articuloAuxiliar = articuloAActualizar.GetArticulo(articuloAActualizar);
            int r = articuloRepository.UpdateArticulo(articuloAuxiliar);

            if (r == 1)
            {
                articuloAActualizar.Mensaje = "Articulo modificado";
                return articuloAActualizar;
            }
            else
            {
                articuloAActualizar.HuboError = true;
                articuloAActualizar.Mensaje = "No se pudo modificar el articulo";
                return articuloAActualizar;

            }



        }

        public ArticuloDTO BorrarArticulo(int id)
        {
            ArticuloDTO articuloAEliminar=new ArticuloDTO();

            int r = articuloRepository.EliminarArticulo(id);

            if (r == 1)
            {
                articuloAEliminar.Mensaje = "Articulo eliminado";
                return articuloAEliminar;
            }
            else
            {
                articuloAEliminar.HuboError = true;
                articuloAEliminar.Mensaje = "No se pudo eliminar el articulo";
                return articuloAEliminar;

            }



        }

        public ArticuloDTO BuscarId(int itemId) { 
        

            ArticuloDTO articuloAuxiliar = new ArticuloDTO();
            
            articuloAuxiliar = articuloAuxiliar.GetArticuloDTO(articuloRepository.GetArticuloById(itemId));

            return articuloAuxiliar;

   
        
        }

        public List<Articulo> GetAllArticulos() {

            return articuloRepository.GetAllArticulos();
        
        
        }


    }
}
